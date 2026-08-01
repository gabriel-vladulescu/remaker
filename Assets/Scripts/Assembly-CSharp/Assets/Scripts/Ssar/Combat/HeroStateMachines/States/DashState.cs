using System;
using Assets.Scripts.Core.FiniteStateMachine;
using Assets.Scripts.Core.Skills;
using Checking;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class DashState : State
	{
		private UserInput userInput;

		private Animation animation;

		private Movement movement;

		private Event event_;

		private Hero hero;

		private Character character;

		private string skillId;

		private NotNullReference notNullReference;

		private bool isDashEnd;

		private float elapsed;

		private bool isDashBrake;

		public DashState(UserInput userInput, Animation animation, Movement movement, Event event_, Hero hero, Character character, string skillId)
		{
			this.userInput = userInput;
			this.animation = animation;
			this.movement = movement;
			this.event_ = event_;
			this.hero = hero;
			this.character = character;
			this.skillId = skillId;
		}

		public string Name()
		{
			return StateName.DASH;
		}

		public void Execute(float dt, StateMachine stateMachine)
		{
			elapsed += dt;
			if (isDashEnd)
			{
				if (userInput.IsInputRun())
				{
					stateMachine.ChangeStateWithHistory(StateName.RUN);
				}
				else
				{
					stateMachine.ChangeStateWithHistory(StateName.IDLE);
				}
			}
		}

		public void Enter(bool resume, string fromStateName)
		{
			isDashEnd = false;
			isDashBrake = false;
			elapsed = 0f;
			event_.ListenToDashEnd(OnDashEnd);
			movement.Dash();
			animation.PlayDash();
		}

		public void Exit()
		{
			event_.UnlistenToDashEnd(OnDashEnd);
		}

		private void OnDashBrakeBegin(object source, EventArgs args)
		{
			isDashBrake = true;
		}

		private void OnDashEnd(object source, EventArgs args)
		{
			isDashEnd = true;
		}
	}
}
