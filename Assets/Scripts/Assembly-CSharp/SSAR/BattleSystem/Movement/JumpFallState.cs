using System;

namespace SSAR.BattleSystem.Movement
{
	public class JumpFallState : IState
	{
		private Action onEnter;

		private Action onExit;

		public void ListenToEnter(Action action)
		{
			onEnter += action;
		}

		public void UnListenToEnter(Action action)
		{
			onEnter -= action;
		}

		public void ListenToExit(Action action)
		{
			onExit += action;
		}

		public void UnListenToExit(Action action)
		{
			onExit -= action;
		}

		public void OnEnter()
		{
			if (onEnter != null)
			{
				onEnter();
			}
		}

		public void OnExit()
		{
			if (onExit != null)
			{
				onExit();
			}
		}
	}
}
