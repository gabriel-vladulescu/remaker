using System.Collections.Generic;
using LitJson;

namespace Scripts.Config
{
	public class DailyLoginConfig : IConfig
	{
		public Dictionary<string, DailyLoginGift> lv1;

		public Dictionary<string, DailyRewardInfo> dailyReward;

		private Dictionary<int, List<DailyLoginGift>> cache;

		private List<DailyRewardInfo> dailyRewardInfos;

		public void OnMapValue(string content)
		{
		}

		private List<DailyLoginGift> SortDictionary(Dictionary<string, DailyLoginGift> dict)
		{
			return null;
		}

		private T MapData<T>(JsonData data) where T : class
		{
			return null;
		}

		public List<DailyLoginGift> GetDailyLoginGifts(int characterLv)
		{
			return null;
		}

		private int CompareDailyLoginGift(DailyLoginGift a, DailyLoginGift b)
		{
			return 0;
		}

		private void MapDailyReward()
		{
		}

		public List<DailyRewardInfo> GetDailyRewardInfos()
		{
			return null;
		}
	}
}
