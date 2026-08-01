using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class Character3RunState : RunState
	{
		public Character3RunState(UserInput userInput, Animation animation, Movement movement, Hero hero, Character character)
			: base(null, null, null, null, null)
		{
		}

		protected override string AttackStateName()
		{
			return null;
		}
	}
}
