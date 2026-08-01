using Assets.Scripts.Core.FiniteStateMachine;
using Assets.Scripts.Core.Skills;
using Checking;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class RunState : State
	{
		private UserInput userInput;

		private Animation animation;

		private Movement movement;

		private Hero hero;

		private readonly Character character;

		private NotNullReference notNullReference;

		public RunState(UserInput userInput, Animation animation, Movement movement, Hero hero, Character character)
		{
			this.userInput = userInput;
			this.animation = animation;
			this.movement = movement;
			this.hero = hero;
			this.character = character;
		}

		public string Name()
		{
			return StateName.RUN;
		}

		public void Execute(float dt, StateMachine stateMachine)
		{
			if (!userInput.IsInputRun())
			{
				stateMachine.ChangeStateWithHistory(StateName.IDLE);
				return;
			}

			if (userInput.IsInputDash() && hero.IsDashAvailable())
			{
				stateMachine.ChangeStateWithHistory(StateName.DASH);
				return;
			}

			if (userInput.IsInputJump() && hero.IsJumpAvailable())
			{
				stateMachine.ChangeStateWithHistory(StateName.JUMP_FALL);
				return;
			}

			if (userInput.IsInputAttack())
			{
				stateMachine.ChangeStateWithHistory(AttackStateName());
				return;
			}

			movement.Run();
		}

		protected virtual string AttackStateName()
		{
			return StateName.COMBO_ATTACK_1;
		}

		public void Enter(bool resume, string fromStateName)
		{
			animation.PlayRun();
			movement.Run();
		}

		public void Exit()
		{
		}
	}
}
