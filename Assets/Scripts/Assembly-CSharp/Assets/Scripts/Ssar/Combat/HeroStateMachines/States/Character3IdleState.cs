namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class Character3IdleState : IdleState
	{
		public Character3IdleState(UserInput userInput, Animation animation, Movement movement, Hero hero)
			: base(null, null, null, null)
		{
		}

		protected override string AttackState()
		{
			return null;
		}
	}
}
