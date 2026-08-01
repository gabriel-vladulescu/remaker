using System.Collections;
using System.Collections.Generic;
using Artemis;
using Artemis.Manager;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using SSAR.BattleSystem.Movement;
using SSAR.BattleSystem.System.Animation.Component;
using SSAR.BattleSystem.System.Event.Component;
using SSAR.BattleSystem.System.Input.Model;
using UnityEngine;

namespace Assets.Scripts.PhaseValidation
{
	// Minimal RoutineRunner that delegates to a host MonoBehaviour, since Unity
	// coroutines can only be started on an actual MonoBehaviour instance.
	public class SimpleRoutineRunner : RoutineRunner
	{
		private MonoBehaviour host;

		public SimpleRoutineRunner(MonoBehaviour host)
		{
			this.host = host;
		}

		public Coroutine StartCoroutine(IEnumerator iterationResult, bool canStopWhenClearScene = true)
		{
			return host.StartCoroutine(iterationResult);
		}

		public void StopCoroutine(IEnumerator iterationResult)
		{
			host.StopCoroutine(iterationResult);
		}

		public void PauseAllCoroutine()
		{
		}

		public void ResumeAllCoroutine()
		{
		}
	}

	// Standalone test harness for validating the Phase 6 movement/state-machine
	// reimplementation in isolation, bypassing the real (and enormous)
	// Dungeon/StrangeIoC/MainCharacterTemplate spawn orchestration, which is not
	// yet implemented. Not part of the original game. Attach to an empty
	// GameObject in a scratch scene and press Play; move with arrow keys.
	public class MovementValidationHarness : MonoBehaviour
	{
		// Minimal stand-in for the abstract Character class. RunState/IdleState
		// hold a reference but don't call into it, so a trivial implementation
		// is sufficient here.
		private class DummyCharacter : Character
		{
			public DummyCharacter()
				: base(null)
			{
			}

			public override bool IsCanPlayAnimationRunInTheAir() => false;
			public override bool IsOnGround() => true;
			public override bool IsInTheAir() => false;
			protected override void LeaveSkillState() { }
			public override CharacterState State() => CharacterState.Default;
			protected override void ChangeToState(CharacterState newState) { }
			public override Vector3 Position() => Vector3.zero;
			public override Vector3 TorsoPosition() => Vector3.zero;
			public override float FacingDirection() => 1f;
			public override void PlayAnimation(string name) { }
			public override void QueueAnimation(string name) { }
			public override void FreezeAnimation(int frame) { }
			public override AbsHeroData HeroData() => null;
			public override string Group() => "1_1";
			public override int Id() => 0;
			public override void Dash(float distance, float duration, float blendTime, bool isInvokedFromEventFrame, bool isFromUserInput, bool ignoreMinSpeedOnAir = false, bool backward = false, AnimationCurve curve = null, float maxSpeed = 0f, bool ignoreMoveDirection = false) { }
			public override void StopDash() { }
			public override void Jump(float height, float durationReachMaxHeight, float distance, float durationLandGround, bool isFromSignatureSkill, float floatingDuration = 0f, bool jumpBackward = false) { }
			public override void InterruptJump() { }
			public override void SetMovingDirectionToLeft() { }
			public override void SetMovingDirectionToRight() { }
			public override void DisplaceBy(Vector3 displacement) { }
			public override void TurnCollider(bool on) { }
			public override void AddAnimationSpeed(string animationName, float bonus) { }
			public override void AdjustCurrentAnimationSpeed(float speed) { }
			public override void AdjustAllAnimationSpeed(float speed) { }
			public override float AnimationDuration(string animationName) => 0f;
			public override void SetAnimationSpeed(float speed) { }
			public override float GetAnimationSpeed() => 1f;
			public override void SetFacingDirectionToLeft() { }
			public override void SetFacingDirectionToRight() { }
			public override void PauseAnimation() { }
			public override void UnpauseAnimation() { }
			public override void SetPosition(Vector3 pos) { }
			public override string CurrentAnimationName() => null;
			public override List<string> CurrentAnimationNames() => null;
			public override GameObject GameObject() => null;
			public override void TurnVisibility(bool on) { }
			public override void SkipFramesOfCurrentPlayingAnimation(int frames) { }
			public override void JumpToFrame(int frame) { }
			public override void TurnParticles(bool on) { }
		}

		private EntityWorld entityWorld;
		private MovementSystem movementSystem;
		private Entity entity;
		private HeroStateMachine heroStateMachine;
		private CharacterInput characterInput;
		private CharacterMove characterMove;

		private void Start()
		{
			GameObject characterGo = GameObject.CreatePrimitive(PrimitiveType.Capsule);
			characterGo.name = "MovementValidation_Character";
			characterGo.transform.position = transform.position;

			entityWorld = new EntityWorld();
			movementSystem = new MovementSystem(false);
			entityWorld.SystemManager.SetSystem(movementSystem, GameLoopType.Update);
			entityWorld.InitializeAll(false);

			entity = entityWorld.CreateEntity();

			MovementConfigData configData = characterGo.AddComponent<MovementConfigData>();
			configData.moveSpeed = 4f;
			configData.jumpHeight = 2.4f;
			configData.jumpDurationMaxHeight = 0.31f;
			configData.jumpDurationLandGround = 0.32f;
			configData.jumpDistance = 10f;
			configData.dashDistance = 6.5f;
			configData.dashDuration = 0.55f;
			configData.dashBlendTime = 0.3f;

			MovementComponent movementComponent = new MovementComponent(configData, 0f, Direction.Right, true, true, -1f);
			entity.AddComponent(movementComponent);

			CharacterMediatorComponent mediator = new CharacterMediatorComponent(characterGo.transform.position, characterGo);
			entity.AddComponent(mediator);

			UnityEngine.Animation nativeAnimation = characterGo.AddComponent<UnityEngine.Animation>();
			CharacterEvent characterEvent = new CharacterEvent();
			entity.AddComponent(new CharacterEventComponent(characterEvent));

			characterInput = new CharacterInput();
			characterMove = new CharacterMove(characterGo, entity, characterInput, characterEvent);
			CharacterJump characterJump = new CharacterJump(entity, 1);
			CharacterAnimation characterAnimation = new CharacterAnimation(nativeAnimation, characterGo.transform, new SimpleRoutineRunner(this), new Dictionary<string, float>());

			heroStateMachine = new HeroStateMachine(characterInput, characterAnimation, characterMove, characterEvent, characterJump, new DummyCharacter(), null);
			heroStateMachine.ListenToStateTransition(delegate(string from, string to, bool resume)
			{
				Debug.Log("[MovementValidationHarness] State transition: " + from + " -> " + to + " (resume=" + resume + ")");
			});

			Debug.Log("[MovementValidationHarness] Ready. Use arrow keys / A-D to move.");
		}

		private void Update()
		{
			if (entity == null)
			{
				return;
			}

			float h = Input.GetAxisRaw("Horizontal");
			if (h > 0f)
			{
				characterInput.Run(new RunRequest(AccessLevel.UserAccess, entity.GetComponent<MovementComponent>().runData, Direction.Right, true), false);
			}
			else if (h < 0f)
			{
				characterInput.Run(new RunRequest(AccessLevel.UserAccess, entity.GetComponent<MovementComponent>().runData, Direction.Left, true), false);
			}
			else
			{
				characterInput.ReleaseRunInput();
			}

			MovementComponent mc = entity.GetComponent<MovementComponent>();
			if (Input.GetKeyDown(KeyCode.Space))
			{
				characterInput.Jump(new JumpRequest(AccessLevel.UserAccess, mc.jumpData));
			}
			if (Input.GetKeyDown(KeyCode.LeftShift))
			{
				characterInput.Dash(new DashRequest(AccessLevel.UserAccess, mc.dashData), 0);
			}

			heroStateMachine.Update(Time.deltaTime);
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
