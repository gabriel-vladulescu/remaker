using System;
using Assets.Scripts.Core.FiniteStateMachine;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class DieState : State
	{
		private Animation animation;

		private Event event_;

		private bool isResurrected;

		public DieState(Animation animation, Event event_)
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

		private void OnResurrection(object source, EventArgs args)
		{
		}
	}
}
