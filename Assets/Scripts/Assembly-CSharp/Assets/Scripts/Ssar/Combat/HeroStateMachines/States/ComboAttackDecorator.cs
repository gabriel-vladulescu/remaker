using Assets.Scripts.Core.FiniteStateMachine;
using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class ComboAttackDecorator : State
	{
		private State origin;

		private UserInput userInput;

		private Character character;

		public string Name()
		{
			return null;
		}

		public void Execute(float dt, StateMachine stateMachine)
		{
		}

		public void Enter(bool resume, string fromStateName)
		{
		}

		public void Exit()
		{
		}
	}
}
