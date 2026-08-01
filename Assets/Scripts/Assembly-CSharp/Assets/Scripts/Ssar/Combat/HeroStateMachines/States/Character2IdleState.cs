using Assets.Scripts.Core.FiniteStateMachine;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class Character2IdleState : IdleState
	{
		private readonly Animation animation;

		private readonly Movement movement;

		public Character2IdleState(UserInput userInput, Animation animation, Movement movement, Hero hero)
			: base(null, null, null, null)
		{
		}

		public override void Execute(float dt, StateMachine stateMachine)
		{
		}

		private bool IsAnimationIsPlaying(string name)
		{
			return false;
		}
	}
}
