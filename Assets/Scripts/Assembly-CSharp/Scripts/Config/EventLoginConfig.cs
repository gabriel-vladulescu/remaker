using System.Collections.Generic;
using Ssar.Event;

namespace Scripts.Config
{
	public class EventLoginConfig : IConfig
	{
		public Dictionary<string, EventTimeInfo> time;

		public Dictionary<string, EventLoginReward> rewards;

		public void OnMapValue(string content)
		{
		}

		public EventTimeInfo GetTimeInfo()
		{
			return null;
		}

		public int GetLoginRewardCount()
		{
			return 0;
		}

		public EventLoginReward[] GetListRewards()
		{
			return null;
		}

		public EventLoginReward GetLoginReward(int day)
		{
			return null;
		}

		public EventLoginReward GetRewardById(int id)
		{
			return null;
		}
	}
}
