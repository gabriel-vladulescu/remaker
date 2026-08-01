using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class Character2JumpAttack2State : JumpAttack1State
	{
		public Character2JumpAttack2State(UserInput userInput, Animation animation, Movement movement, Event event_, Hero hero, Character character, string skillId, ComboAttackState.AnimationFrame animationFrame, ComboAttackState.IgnoreInputWindow ignoreInputWindow, JumpAttack1StateMovement ja1sm = null)
			: base(null, null, null, null, null, null, null, null, null)
		{
		}

		protected override bool IsNextAttackAvailable()
		{
			return false;
		}
	}
}
