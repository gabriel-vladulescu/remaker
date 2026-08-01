using Artemis;
using Artemis.Manager;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using SSAR.BattleSystem.EntityTemplate;
using SSAR.BattleSystem.Movement;
using SSAR.BattleSystem.System.Input.Model;
using Scripts.Config;
using Scripts.Config.Stats;
using UnityEngine;

namespace Assets.Scripts.PhaseValidation
{
	// Same purpose as MovementValidationHarness, but spawns the real
	// Spine-rigged character prefab through the real MainCharacterTemplate /
	// EntityTemplateManager chain instead of a bare capsule + hand-built
	// components. Not part of the original game.
	public class RealCharacterValidationHarness : MonoBehaviour
	{
		// AbsHeroData is entangled with the full equipment/mastery/skill config
		// system (see HeroData.cs) which movement doesn't need. OnBuild only
		// actually reads groupId/subId, so a minimal stand-in is enough here.
		private class MinimalHeroData : AbsHeroData
		{
			public MinimalHeroData(int groupId, int subId, int level)
				: base(groupId, subId, level)
			{
			}

			public override EntityAbilities GetTotalStats() => new EntityAbilities();
			public override HeroBasicStats GetHeroBasicStats() => null;
			public override HeroLevelStats GetHeroLevelStats() => null;
		}

		[SerializeField]
		private string prefabResourcePath = "characters/group_1/1/1_1_Prefab";

		private EntityWorld entityWorld;
		private Entity entity;
		private HeroStateMachine heroStateMachine;
		private CharacterInput characterInput;

		private void Start()
		{
			GameObject prefab = Resources.Load<GameObject>(prefabResourcePath);
			if (prefab == null)
			{
				Debug.LogError("[RealCharacterValidationHarness] Could not load prefab at Resources/" + prefabResourcePath);
				return;
			}

			GameObject instance = MainCharacterTemplate.InstantiateGameObjectFromPrefab(prefab);
			instance.transform.position = transform.position;

			entityWorld = new EntityWorld();
			entityWorld.SystemManager.SetSystem(new MovementSystem(false), GameLoopType.Update);
			entityWorld.SystemManager.SetSystem(new HeroStateMachineSystem(false), GameLoopType.Update);
			entityWorld.InitializeAll(false);
			// InitializeAll(false) skips [ArtemisEntityTemplate] reflection scanning
			// (deliberately, to avoid auto-discovering every other stub template in
			// the codebase) so MainCharacterTemplate needs registering by hand.
			entityWorld.SetEntityTemplate("MainChracter", new MainCharacterTemplate());

			EntityTemplateManager templateManager = new EntityTemplateManager();
			templateManager.Init(entityWorld);

			MinimalHeroData heroData = new MinimalHeroData(1, 1, 1);
			BaseHeroTemplateArgs args = new BaseHeroTemplateArgs(heroData, new EntityAbilities(), transform.position, instance);

			entity = templateManager.CreateMainCharacter(args);
			if (entity == null)
			{
				Debug.LogError("[RealCharacterValidationHarness] CreateMainCharacter returned null.");
				return;
			}

			heroStateMachine = entity.GetComponent<HeroStateMachineComponent>().heroStateMachine;
			characterInput = entity.GetComponent<CharacterInputComponent>().CharacterInput;

			heroStateMachine.ListenToStateTransition(delegate(string from, string to, bool resume)
			{
				Debug.Log("[RealCharacterValidationHarness] State transition: " + from + " -> " + to + " (resume=" + resume + ")");
			});

			Debug.Log("[RealCharacterValidationHarness] Ready. Use arrow keys / A-D to move.");
		}

		private void Update()
		{
			if (entity == null)
			{
				return;
			}

			float h = Input.GetAxisRaw("Horizontal");
			MovementComponent mc = entity.GetComponent<MovementComponent>();
			if (h > 0f)
			{
				characterInput.Run(new RunRequest(AccessLevel.UserAccess, mc.runData, Direction.Right, true), false);
			}
			else if (h < 0f)
			{
				characterInput.Run(new RunRequest(AccessLevel.UserAccess, mc.runData, Direction.Left, true), false);
			}
			else
			{
				characterInput.ReleaseRunInput();
			}

			if (Input.GetKeyDown(KeyCode.Space))
			{
				characterInput.Jump(new JumpRequest(AccessLevel.UserAccess, mc.jumpData));
			}
			if (Input.GetKeyDown(KeyCode.LeftShift))
			{
				characterInput.Dash(new DashRequest(AccessLevel.UserAccess, mc.dashData), 0);
			}

			entityWorld.Update((long)(Time.deltaTime * System.TimeSpan.TicksPerSecond));

			characterInput.ReleaseInputJump();
			characterInput.ReleaseInputDash();
		}

		private void OnGUI()
		{
			if (heroStateMachine == null)
			{
				return;
			}
			GUI.Label(new Rect(10, 10, 400, 30), "State: " + heroStateMachine.GetCurrentStateName());
		}
	}
}
