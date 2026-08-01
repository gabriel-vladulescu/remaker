using System.Collections.Generic;
using Scripts.Config;

namespace Scripts.Ssar.Arena
{
	public class RewardListRowData
	{
		private List<ItemInfo> reward;

		private string text;

		private SeasonalRankRewardValue rankRewardValue;

		public RewardListRowData(SeasonalRankRewardValue rankHigher, SeasonalRankRewardValue currentRank, int seasonCode)
		{
		}

		public string GetRankText()
		{
			return null;
		}

		public List<ItemInfo> GetRewards()
		{
			return null;
		}

		public SeasonalRankRewardValue GetRankRewardInfo()
		{
			return null;
		}
	}
}
