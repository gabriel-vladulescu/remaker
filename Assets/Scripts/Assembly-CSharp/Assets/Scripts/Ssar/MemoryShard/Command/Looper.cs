using Assets.Scripts.Core.Scheduling;
using Assets.Scripts.Utils;

namespace Assets.Scripts.Ssar.MemoryShard.Command
{
	public class Looper : SimTimeObserver
	{
		private EaseMove em;

		public Looper(EaseMove em)
		{
		}

		public void OnSimTime(uint dt)
		{
		}
	}
}
