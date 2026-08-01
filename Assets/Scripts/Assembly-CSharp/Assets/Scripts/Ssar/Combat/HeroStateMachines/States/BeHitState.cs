using System;
using Assets.Scripts.Core.FiniteStateMachine;
using Checking;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class BeHitState : State
	{
		private UserInput userInput;

		private Animation animation;

		private Movement movement;

		private Event event_;

		private NotNullReference notNullReference;

		private bool isBeHitAnimationEnd;

		private bool isBeHitInTheAir;

		private bool isFallEnd;

		public BeHitState(UserInput userInput, Animation animation, Movement movement, Event event_)
		{
		}

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

		private void OnFallEnd(object source, EventArgs args)
		{
		}

		public void Exit()
		{
		}

		private void OnBeHitAnimationEnd(object source, EventArgs args)
		{
		}
	}
}
