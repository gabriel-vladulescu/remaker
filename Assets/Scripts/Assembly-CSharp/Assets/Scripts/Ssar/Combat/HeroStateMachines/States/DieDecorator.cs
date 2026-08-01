using System;
using Assets.Scripts.Core.FiniteStateMachine;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class DieDecorator : State
	{
		private State original;

		private Event event_;

		private bool isDie;

		public DieDecorator(State original, Event @event)
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

		private void OnDie(object source, EventArgs args)
		{
		}
	}
}
