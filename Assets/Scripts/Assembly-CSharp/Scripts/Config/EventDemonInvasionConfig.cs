using System.Collections.Generic;
using Ssar.Event.DemonInvasion.Config;

namespace Scripts.Config
{
	public class EventDemonInvasionConfig : IConfig
	{
		public Dictionary<string, DemonInvasionInfo> time;

		public Dictionary<string, DemonInvasionReward> rewards;

		public Dictionary<string, DemonInvasionLoginGift> gifts;

		public Dictionary<string, DemonInvasionRank> ranks;

		public Dictionary<string, DemonPassProductInfo> shop;

		private DemonPassProductInfo demonPassProductInfo;

		public void OnMapValue(string content)
		{
		}

		public string GetDemonPassSku()
		{
			return null;
		}

		public DemonPassProductInfo GetDemonPassProductInfo()
		{
			return null;
		}

		public DemonInvasionInfo GetChallengeTimeInfo()
		{
			return null;
		}

		public DemonInvasionInfo GetDailyLoginTimeInfo()
		{
			return null;
		}

		public DemonInvasionInfo GetEventTimeInfo()
		{
			return null;
		}

		public DemonInvasionReward[] GetRewards()
		{
			return null;
		}

		public DemonInvasionLoginGift[] GetGifts()
		{
			return null;
		}

		public DemonInvasionRank[] GetRanks()
		{
			return null;
		}

		public string GetNameRank(int id)
		{
			return null;
		}
	}
}
