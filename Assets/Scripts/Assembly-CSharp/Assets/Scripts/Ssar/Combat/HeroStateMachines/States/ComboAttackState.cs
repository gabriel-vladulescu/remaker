using Assets.Scripts.Core.FiniteStateMachine;
using Assets.Scripts.Core.Skills;
using Checking;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public abstract class ComboAttackState : State
	{
		public class IgnoreInputWindow
		{
			private float start;

			private float end;

			public IgnoreInputWindow(float start, float end)
			{
			}

			public bool IsIgnore(float time)
			{
				return false;
			}

			public float Start()
			{
				return 0f;
			}

			public float End()
			{
				return 0f;
			}
		}

		public class AcceptInputWindow
		{
			private float start;

			private float end;

			public AcceptInputWindow(float start, float end)
			{
			}

			public bool IsAccept(float time)
			{
				return false;
			}

			public float Start()
			{
				return 0f;
			}

			public float End()
			{
				return 0f;
			}
		}

		public class AnimationFrame
		{
			private float startupDuration;

			private float activeDuration;

			private float recoveryDuration;

			public AnimationFrame(float startupDuration, float activeDuration, float recoveryDuration)
			{
			}

			public float Duration()
			{
				return 0f;
			}

			public bool IsInStartup(float time)
			{
				return false;
			}

			public bool IsInActive(float time)
			{
				return false;
			}

			public bool IsInRecovery(float time)
			{
				return false;
			}

			public float ActiveFrameStart()
			{
				return 0f;
			}

			public float RecoveryFrameStart()
			{
				return 0f;
			}
		}

		private float delayAcceptUserAttackInput;

		private float delayAcceptUserInterruptionInput;

		private UserInput userInput;

		private Animation animation;

		private Movement movement;

		private Event event_;

		private Hero hero;

		private readonly Character character;

		private NotNullReference notNullReference;

		private bool isAnimationEnd;

		private bool isActiveFrameEnd;

		private bool isAttackInputAcceptable;

		private bool isAttackInputRecognized;

		private float elapsed;

		private bool isRunInputAcceptable;

		private IgnoreInputWindow ignoreInputWindow;

		private AcceptInputWindow attackAcceptInputWindow;

		private bool isRunInputRecognized;

		private bool isInputRunBeforeEnter;

		private bool isFacingDirectionChangeForRunRecognized;

		private bool isInterruptionInputAcceptable;

		private bool isJumpInputRecognized;

		private bool isDashInputRecognized;

		public ComboAttackState(UserInput userInput, Animation animation, Movement movement, Event event_, Hero hero, Character character)
		{
		}

		public virtual string Name()
		{
			return null;
		}

		public void Execute(float dt, StateMachine stateMachine)
		{
		}

		public virtual void Enter(bool resume, string fromStateName)
		{
		}

		public virtual void Exit()
		{
		}

		protected abstract string NextState();

		protected abstract IgnoreInputWindow GetIgnoreInputWindowOfInterruptionInputs();

		protected abstract AnimationFrame GetAnimationFrame();

		protected virtual string StateWhenInputAttackAtRecovery()
		{
			return null;
		}
	}
}
