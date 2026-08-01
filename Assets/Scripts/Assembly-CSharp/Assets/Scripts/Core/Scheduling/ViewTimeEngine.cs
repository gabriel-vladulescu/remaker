using System.Collections.Generic;
using Assets.Scripts.Core.Utils;

namespace Assets.Scripts.Core.Scheduling
{
	public class ViewTimeEngine
	{
		private const int MAX_PHYS_FRAMES_PER_VIEW_FRAME = 5;

		private float timePerFrame;

		private float timeLast;

		private List<ViewPhysicsTimeObserver> physTimeObservers;

		private List<ViewFrameTimeObserver> frameTimeObservers;

		private List<ViewClockTimeObserver> clockTimeObservers;

		private MutableIterator physMiter;

		private MutableIterator frameMiter;

		private MutableIterator clockMiter;

		public ViewTimeEngine(float timePerFrame)
		{
		}

		public void RegisterPhysicsTimeObserver(ViewPhysicsTimeObserver observer)
		{
		}

		public void UnregisterPhysicsTimeObserver(ViewPhysicsTimeObserver observer)
		{
		}

		public void RegisterFrameTimeObserver(ViewFrameTimeObserver observer)
		{
		}

		public void UnregisterFrameTimeObserver(ViewFrameTimeObserver observer)
		{
		}

		public void RegisterClockTimeObserver(ClockTimeObserver observer, float tickSize)
		{
		}

		public void UnregisterClockTimeObserver(ClockTimeObserver observer)
		{
		}

		public void UnregisterAll()
		{
		}

		public void OnUpdate()
		{
		}

		private float Now()
		{
			return 0f;
		}
	}
}
