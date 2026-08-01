using System.Collections.Generic;

namespace Ssar.RaidBoss.API
{
	public class GlobalRewardStatus
	{
		public bool isAvailable;

		public List<int> progress;

		public GlobalRewardStatus(bool isAvailable, string progressRaw = null)
		{
		}

		public GlobalRewardStatus(bool isAvailable, List<int> progress)
		{
		}

		private List<int> ReadProgressData(string raw)
		{
			return null;
		}
	}
}
