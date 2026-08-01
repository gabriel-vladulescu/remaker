using Assets.Scripts.Core.FiniteStateMachine;
using Checking;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class IdleState : State
	{
		private UserInput userInput;

		private Animation animation;

		private Movement movement;

		private Hero hero;

		private NotNullReference notNullReference;

		public IdleState(UserInput userInput, Animation animation, Movement movement, Hero hero)
		{
			this.userInput = userInput;
			this.animation = animation;
			this.movement = movement;
			this.hero = hero;
		}

		public string Name()
		{
			return StateName.IDLE;
		}

		public virtual void Execute(float dt, StateMachine stateMachine)
		{
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
				stateMachine.ChangeStateWithHistory(AttackState());
				return;
			}

			if (userInput.IsInputRun())
			{
				stateMachine.ChangeStateWithHistory(StateName.RUN);
			}
		}

		public virtual void Enter(bool resume, string fromStateName)
		{
			animation.PlayIdle();
			movement.ForceStop();
		}

		public void Exit()
		{
		}

		protected virtual string AttackState()
		{
			return StateName.COMBO_ATTACK_1;
		}
	}
}
