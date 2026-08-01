using Assets.Scripts.Core.FiniteStateMachine;
using Assets.Scripts.Core.Skills;
using Checking;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class ComboAttack4State : State
	{
		private float delayAcceptUserAttackInput;

		private UserInput userInput;

		private Animation animation;

		private Movement movement;

		private Event event_;

		private Hero hero;

		private readonly Character character;

		private readonly string skillId;

		private ComboAttackState.IgnoreInputWindow ignoreInputWindow;

		private ComboAttackState.AnimationFrame animationFrame;

		private NotNullReference notNullReference;

		private bool isAnimationEnd;

		private bool isActiveFrameEnd;

		private bool isDamageDealingFrame;

		private bool isDamageDealt;

		private bool isAttackInputAcceptable;

		private bool isAttackInputRecognized;

		private ComboAttackState.IgnoreInputWindow runIgnoreInputWindow;

		private float elapsed;

		private bool isRunInputAcceptable;

		private bool isRunInputRecognized;

		private ComboAttackState.AcceptInputWindow attackAcceptInputWindow;

		private bool isJumpInputRecognized;

		private bool isDashInputRecognized;

		public ComboAttack4State(UserInput userInput, Animation animation, Movement movement, Event event_, Hero hero, Character character, string skillId, ComboAttackState.IgnoreInputWindow iiw, ComboAttackState.AnimationFrame af)
		{
		}

		public string Name()
		{
			return null;
		}

		public void Execute(float dt, StateMachine stateMachine)
		{
		}

		private ComboAttackState.AnimationFrame GetAnimationFrame()
		{
			return null;
		}

		private ComboAttackState.IgnoreInputWindow GetRunIgnoreInputWindow()
		{
			return null;
		}

		public void Enter(bool resume, string fromStateName)
		{
		}

		public void Exit()
		{
		}
	}
}
