using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class ComboAttack2State : ComboAttackState
	{
		private Hero hero;

		private Animation animation;

		private readonly Character character;

		private readonly string skillId;

		private IgnoreInputWindow ignoreInputWindow;

		private AnimationFrame animationFrame;

		public ComboAttack2State(UserInput userInput, Animation animation, Movement movement, Event event_, Hero hero, Character character, string skillId, IgnoreInputWindow iiw, AnimationFrame af)
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

		protected override string StateWhenInputAttackAtRecovery()
		{
			return null;
		}
	}
}
