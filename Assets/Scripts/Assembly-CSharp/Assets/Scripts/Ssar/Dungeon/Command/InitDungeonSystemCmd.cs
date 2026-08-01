using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Artemis;
using Artemis.Interface;
using Artemis.Manager;
using Artemis.System;
using Assets.Scripts.Ssar.Common.System.Resources;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using Assets.Scripts.Ssar.Dungeon;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Assets.Scripts.Ssar.Dungeon.Environment;
using Assets.Scripts.Ssar.Dungeon.Environment.Character;
using Assets.Scripts.Ssar.Dungeon.Environment.Monster;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.Model;
using Assets.Scripts.Ssar.Dungeon.Signal;
using Assets.Scripts.Ssar.Dungeon.Spawn;
using Assets.Scripts.Ssar.Dungeon.Stages;
using SSAR.BattleSystem.Camera;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.EntityTemplate;
using SSAR.BattleSystem.Movement;
using SSAR.BattleSystem.System.Input.Model;
using Scripts.Config;
using Scripts.Config.Stats;
using Ssar.Achievement;
using Ssar.DailyQuest;
using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.injector.api;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class InitDungeonSystemCmd : strange.extensions.command.impl.Command
	{
		public class SpawnedMonsterList
		{
			public class SpawnedMonster
			{
				private bool isSpawned;

				private int ticketId;

				private bool beatable;

				public SpawnedMonster(int ticketId)
				{
				}

				public bool IsSpawned()
				{
					return false;
				}

				public void OnSpawn()
				{
				}

				public int TicketId()
				{
					return 0;
				}

				public void SetBeatable(bool beatable)
				{
				}

				public bool IsBeatable()
				{
					return false;
				}
			}

			public class SpawnedMonsterTicketComponent : IComponent
			{
				private int ticketId;

				public SpawnedMonsterTicketComponent(int ticketId)
				{
				}

				public int TicketId()
				{
					return 0;
				}
			}

			private Dungeon dungeon;

			private Dictionary<string, List<SpawnedMonster>> spawnedMonsterByStage;

			private int ticketId;

			private int currentStageOrder;

			public SpawnedMonsterList(Dungeon dungeon)
			{
			}

			public int RandomUnusedTicketId(int stageOrder)
			{
				return 0;
			}

			public List<SpawnedMonster> ListAllSpawnedMonsterOfStage(int stageOrder)
			{
				return null;
			}

			private void OnStageCycle(int stageorder, Dungeon.StageCycle cycle)
			{
			}

			public virtual int ObtainTicket()
			{
				return 0;
			}

			public void MarkMonsterAsSpawned(int spawnedTicketId)
			{
			}

			public void MarkMonsterBeatable(int spawnedTicketId, bool beatable)
			{
			}
		}

		public class DungeonStateMonitor : EntitySystemWithTime
		{
			public Action<int, Dungeon.StageCycle> onGateCycle;

			private Dungeon dungeon;

			private CameraComponent cameraComponent;

			private SpawnedMonsterList spawnedMonsterList;

			private new EntityWorld entityWorld;

			private readonly DefaultEnvironment env;

			private DungeonResult previousResult;

			private int currentStageOrder;

			public DungeonStateMonitor(Dungeon dungeon, CameraComponent cameraComponent, SpawnedMonsterList sml, EntityWorld ew, DefaultEnvironment env)
			{
			}

			private void StageWaveCycle(int stageOrder, int waveOrder, DefaultStage.WaveCycle cycle)
			{
			}

			public DefaultEnvironment GetDefaultEnvironment()
			{
				return null;
			}

			private void OnDungeonEvent(Dungeon.DungeonEvent dungeonEvent)
			{
			}

			protected override void Process(float deltaTime)
			{
			}

			private void OnGateCycle(int gateOrder, Dungeon.GateCycle cycle)
			{
			}

			private void OnStageCycle(int stageOrder, Dungeon.StageCycle cycle)
			{
			}

			private void ChangeCameraBoundaries(int stageNumber)
			{
			}
		}

		private class EntityDeathListener
		{
			private class DefaultMonster : Monster
			{
				private float deadTime;

				private MonsterType type;

				private string configId;

				private int spawnId;

				public DefaultMonster(float deadTime, MonsterType type, string configId, int spawnId)
				{
				}

				public float DeadTime()
				{
					return 0f;
				}

				public MonsterType Type()
				{
					return default(MonsterType);
				}

				public string ConfigId()
				{
					return null;
				}

				public int SpawnId()
				{
					return 0;
				}
			}

			private DamageCalculationSystem damageCalculationSystem;

			private DefaultEnvironment environment;

			private EntityWorld entityWorld;

			public EntityDeathListener(DamageCalculationSystem damageCalculationSystem, DefaultEnvironment environment, EntityWorld entityWorld)
			{
			}

			public void Act()
			{
			}

			private void OnEntityDeath(Entity entity)
			{
			}
		}

		private class DefaultCharacter : Character
		{
			private HealthComponent healthComponent;

			private CharacterMediatorComponent characterMediatorComponent;

			public DefaultCharacter(HealthComponent healthComponent, CharacterMediatorComponent characterMediatorComponent)
			{
			}

			public Vector3 Position()
			{
				return default(Vector3);
			}

			public bool IsDead()
			{
				return false;
			}
		}

		public class DefaultGameObjectSpawner : GameObjectSpawner
		{
			private SpawnMonsterSignal spawnMonsterSignal;

			private IInjectionBinder injectionBinder;

			public DefaultGameObjectSpawner(IInjectionBinder injectionBinder)
			{
			}

			public override GameObject SpawnCharacter()
			{
				return null;
			}

			public override GameObject SpawnMonster(string id)
			{
				return null;
			}

			public override GameObject SpawnMonster(string id, float spawnX, float spawnY, SpawnSource spawnSource, Action<GameObject, int> onSpawnSuccess)
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDelay_003Ed__34(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		// The full game presumably injects battleModeLogic/ResourcesLoader/
		// dungeonConfig/achievementLogic/configManager/routineRunner/dql here
		// too, but StrangeIoC's Injector throws (rather than injecting null)
		// for any [Inject] property with no binding, so every dependency this
		// simplified Execute() doesn't actually use has to stay unbound and
		// therefore un-injected, or the command never reaches Execute() at
		// all. Only the two signals actually used below are kept.
		[Inject]
		public OnDungeonStartSignal OnDungeonStartSignal { get; set; }

		[Inject]
		public OnSpawnMainCharacterSignal OnSpawnMainCharacterSignal { get; set; }

		// AbsHeroData is entangled with the full equipment/mastery/skill config
		// system (see HeroData.cs), which movement doesn't need yet. OnBuild
		// only reads groupId/subId, so a minimal stand-in is enough here (same
		// approach as RealCharacterValidationHarness.MinimalHeroData).
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

		// Simplified boot: skips monster spawning, achievements, daily quests,
		// camera boundaries and the full cosmetic/equipment spawn pipeline
		// (SpawnMainCharacterCmd/AbsSpawnCharacterCmd), none of which movement
		// testing needs. Spawns the real character prefab through the real
		// MainCharacterTemplate/EntityTemplateManager chain, same as
		// RealCharacterValidationHarness, but wired into the actual Dungeon
		// scene via StrangeIoC instead of a standalone test scene.
		public override void Execute()
		{
			GameObject prefab = UnityEngine.Resources.Load<GameObject>(DungeonSelection.HeroPrefabResourcePath);
			if (prefab == null)
			{
				UnityEngine.Debug.LogError("[InitDungeonSystemCmd] Could not load prefab at Resources/" + DungeonSelection.HeroPrefabResourcePath);
				return;
			}

			GameObject instance = MainCharacterTemplate.InstantiateGameObjectFromPrefab(prefab);
			instance.transform.position = Vector3.zero;
			AssignDefaultWeaponMaterial(instance);

			EntityWorld entityWorld = new EntityWorld();
			entityWorld.SystemManager.SetSystem(new MovementSystem(false), GameLoopType.Update);
			entityWorld.SystemManager.SetSystem(new HeroStateMachineSystem(false), GameLoopType.Update);
			entityWorld.InitializeAll(false);
			// InitializeAll(false) skips [ArtemisEntityTemplate] reflection
			// scanning (deliberately, to avoid auto-discovering every other
			// unfinished stub template in the codebase), so MainCharacterTemplate
			// needs registering by hand.
			entityWorld.SetEntityTemplate("MainChracter", new MainCharacterTemplate());

			EntityTemplateManager templateManager = new EntityTemplateManager();
			templateManager.Init(entityWorld);

			MinimalHeroData heroData = new MinimalHeroData(DungeonSelection.HeroGroupId, DungeonSelection.HeroSubId, DungeonSelection.HeroLevel);
			BaseHeroTemplateArgs args = new BaseHeroTemplateArgs(heroData, new EntityAbilities(), instance.transform.position, instance);

			Entity mainCharacter = templateManager.CreateMainCharacter(args);
			if (mainCharacter == null)
			{
				UnityEngine.Debug.LogError("[InitDungeonSystemCmd] CreateMainCharacter returned null.");
				return;
			}

			CharacterInput characterInput = mainCharacter.GetComponent<CharacterInputComponent>().CharacterInput;

			GameObject driverGo = new GameObject("DungeonSimulationDriver");
			DungeonSimulationDriver driver = driverGo.AddComponent<DungeonSimulationDriver>();
			driver.Init(entityWorld, characterInput, instance.transform);

			// The real Dungeon.unity scene doesn't have UserButtonInputLayout
			// placed statically; it's instantiated at runtime from this
			// Resources prefab. View.Start()/OnEnable() auto-registers with
			// Context.firstContext, which is what actually creates
			// UserButtonInputLayoutMediator - no manual AddView() call needed.
			// It also has no UIRoot/UIPanel/UICamera of its own - the real
			// game gets those from a persistent UI root set up once during
			// the EntryScene/LoadingScene boot flow (DontDestroyOnLoad) that
			// this simplified boot skips by opening Dungeon.unity directly,
			// so one is built here instead.
			Transform uiRoot = SpawnPlaceholderUIRoot();
			GameObject buttonLayoutPrefab = UnityEngine.Resources.Load<GameObject>("guiprefabs/UserButtonInputController");
			if (buttonLayoutPrefab != null)
			{
				UnityEngine.Object.Instantiate(buttonLayoutPrefab, uiRoot);
			}
			else
			{
				UnityEngine.Debug.LogError("[InitDungeonSystemCmd] Could not load prefab at Resources/guiprefabs/UserButtonInputController");
			}

			if (OnSpawnMainCharacterSignal != null)
			{
				OnSpawnMainCharacterSignal.Dispatch(mainCharacter);
			}

			UnityEngine.Debug.Log("[InitDungeonSystemCmd] Simplified dungeon boot complete: main character spawned.");
		}

		// The weapon's SkinnedMeshRenderer in the base prefab has no material
		// assigned at all - it references Unity's built-in Default-Material
		// fallback (renders solid white). The real game assigns the equipped
		// weapon's material at runtime via AbsSpawnCharacterCmd.ReplaceWeapon,
		// which is part of the full cosmetic/equipment pipeline this
		// simplified boot skips. This just assigns the character's default
		// (non-cosmetic) weapon material directly so the weapon isn't blank.
		private void AssignDefaultWeaponMaterial(GameObject characterInstance)
		{
			Transform weapon = characterInstance.transform.Find("weapon");
			if (weapon == null)
			{
				return;
			}
			SkinnedMeshRenderer renderer = weapon.GetComponent<SkinnedMeshRenderer>();
			if (renderer == null)
			{
				return;
			}
			Material defaultWeaponMaterial = UnityEngine.Resources.Load<Material>("characters/group_1/1/equipment/weapon/default/material/1_1_weapon_Material");
			if (defaultWeaponMaterial != null)
			{
				renderer.material = defaultWeaponMaterial;
			}
		}

		// Builds a minimal UIRoot + overlay UICamera so NGUI's touch/mouse
		// event dispatch and screen-space scaling actually work for the
		// dynamically-instantiated UserButtonInputController above. Settings
		// (orthographic size 1, ClearFlags=Depth only, Depth=99, UIRoot
		// FixedSize/1280x720) mirror the persistent UI camera found in
		// LoadingScene.unity, which is normally created once during the
		// EntryScene/LoadingScene boot flow and kept alive via
		// DontDestroyOnLoad - not present here since this simplified boot
		// opens Dungeon.unity directly. Not part of the original game.
		//
		// If a real UICamera already exists (e.g. carried into this scene by
		// the real boot chain via DontDestroyOnLoad), this steps aside
		// entirely and reuses its transform instead of creating a competing
		// second one.
		private Transform SpawnPlaceholderUIRoot()
		{
			if (UICamera.list.size > 0)
			{
				Transform existingCamTransform = UICamera.list.buffer[0].transform;
				return existingCamTransform.parent != null ? existingCamTransform.parent : existingCamTransform;
			}

			GameObject rootGo = new GameObject("PlaceholderUIRoot");
			UIRoot uiRoot = rootGo.AddComponent<UIRoot>();
			uiRoot.scalingStyle = UIRoot.Scaling.FixedSize;
			uiRoot.manualHeight = 720;
			uiRoot.minimumHeight = 600;
			uiRoot.maximumHeight = 1536;

			GameObject camGo = new GameObject("PlaceholderUICamera");
			camGo.transform.SetParent(rootGo.transform, false);
			Camera cam = camGo.AddComponent<Camera>();
			cam.clearFlags = CameraClearFlags.Depth;
			cam.orthographic = true;
			cam.orthographicSize = 1f;
			cam.nearClipPlane = -10f;
			cam.farClipPlane = 10f;
			cam.depth = 99f;
			cam.cullingMask = LayerMask.GetMask("UI");
			camGo.AddComponent<UICamera>();

			return rootGo.transform;
		}

		private void InitDungeon(Entity main, List<GameObject> gates, int dungeonId, Entity camera)
		{
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__34))]
		private IEnumerator Delay()
		{
			return null;
		}

		private void FinishInit()
		{
		}
	}
}
