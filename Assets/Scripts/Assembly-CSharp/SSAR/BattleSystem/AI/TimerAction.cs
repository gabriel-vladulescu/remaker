using System;

namespace SSAR.BattleSystem.AI
{
	public class TimerAction
	{
		private readonly float time;

		private Action action;

		private float t;

		private bool isDone;

		private int frame;

		private int c;

		public bool IsDone => false;

		public TimerAction(float time, Action action)
		{
		}

		public TimerAction()
		{
		}

		public TimerAction TimerFrame(int frame, Action action)
		{
			return null;
		}

		public void Reset()
		{
		}

		public void Update(float deltaTime)
		{
		}
	}
}
