using System.Collections.Generic;
using Assets.Scripts.Core.Utils;

namespace Assets.Scripts.Core.Scheduling
{
	public class SimTimeEngine
	{
		private uint timePerFrame;

		private uint timeLast;

		private List<SimTimeObserver> observers;

		private MutableIterator miter;

		private float scale;

		public SimTimeEngine(uint timePerFrame)
		{
		}

		public void RegisterSimTimeObserver(SimTimeObserver observer)
		{
		}

		public void UnregisterSimTimeObserver(SimTimeObserver observer)
		{
		}

		public void UnregisterAll()
		{
		}

		public void ScaleTime(float scale)
		{
		}

		public bool IsPaused()
		{
			return false;
		}

		public void OnUpdate()
		{
		}

		private uint Now()
		{
			return 0u;
		}
	}
}
