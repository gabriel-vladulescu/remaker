using System.Collections.Generic;
using Ssar.Event.EventWar.Config;

namespace Scripts.Config
{
	public class EventWarConfig : IConfig
	{
		public Dictionary<string, EventWarInfo> time;

		public Dictionary<string, EventWarReward> rewards;

		public void OnMapValue(string content)
		{
		}

		public EventWarInfo GetTimeInfo()
		{
			return null;
		}

		public int GetWarRewardCount()
		{
			return 0;
		}

		public EventWarReward GetWarReward(int id)
		{
			return null;
		}

		public EventWarReward[] GetListWarRewards()
		{
			return null;
		}
	}
}
