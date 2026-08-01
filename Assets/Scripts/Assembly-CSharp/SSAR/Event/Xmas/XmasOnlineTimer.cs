using Assets.Scripts.Core.Scheduling;

namespace Ssar.Event.Xmas
{
	public class XmasOnlineTimer : SimTimeObserver
	{
		private MainCharacterData mainCharacterData;

		private bool activated;

		private float time;

		private const float DELAY = 1f;

		public void Activate(MainCharacterData mainCharacterData)
		{
		}

		public void OnSimTime(uint dt)
		{
		}
	}
}
