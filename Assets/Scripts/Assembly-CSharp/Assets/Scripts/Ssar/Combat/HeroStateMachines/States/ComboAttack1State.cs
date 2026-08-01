using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class ComboAttack1State : ComboAttackState
	{
		private Animation animation;

		private Hero hero;

		private Character character;

		private string skillId;

		private IgnoreInputWindow ignoreInputWindow;

		private AnimationFrame animationFrame;

		public ComboAttack1State(UserInput userInput, Animation animation, Movement movement, Event event_, Hero hero, Character character, string skillId, IgnoreInputWindow iiw, AnimationFrame af)
			: base(null, null, null, null, null, null)
		{
		}

		public override string Name()
		{
			return null;
		}

		public override void Enter(bool resume, string fromStateName)
		{
		}

		public override void Exit()
		{
		}

		protected override string NextState()
		{
			return null;
		}

		protected override IgnoreInputWindow GetIgnoreInputWindowOfInterruptionInputs()
		{
			return null;
		}

		protected override AnimationFrame GetAnimationFrame()
		{
			return null;
		}
	}
}
