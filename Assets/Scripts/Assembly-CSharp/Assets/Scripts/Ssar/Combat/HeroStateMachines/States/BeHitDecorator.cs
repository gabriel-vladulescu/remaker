using System;
using Assets.Scripts.Core.FiniteStateMachine;
using Checking;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class BeHitDecorator : State
	{
		private State origin;

		private Event event_;

		private bool isReplaceCurrentState;

		private NotNullReference notNullReference;

		private bool beHit;

		public BeHitDecorator(State origin, Event @event, bool isReplaceCurrentState = true)
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

		public void Exit()
		{
		}

		private void OnBeHit(object source, EventArgs args)
		{
		}
	}
}
