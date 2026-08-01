using Assets.Scripts.Core.Scheduling;

namespace SSAR.Entry.Model
{
	public class PlayTimeManager : SimTimeObserver
	{
		private float delay;

		private float t;

		private float pauseTime;

		private UserData userData;

		private float lastRealTime;

		public void UpdateUserdata(UserData userData)
		{
		}

		private void OnPause()
		{
		}

		private void OnUnpause()
		{
		}

		public void OnSimTime(uint dt)
		{
		}
	}
}
