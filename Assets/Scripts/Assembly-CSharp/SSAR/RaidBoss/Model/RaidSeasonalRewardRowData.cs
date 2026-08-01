using System.Collections.Generic;
using Scripts.Config;

namespace Ssar.RaidBoss.Model
{
	public class RaidSeasonalRewardRowData
	{
		private List<ItemInfo> rewards;

		private string text;

		private RaidBossConfig.SeasonalRankRewardValue rankReward;

		public RaidSeasonalRewardRowData(RaidBossConfig.SeasonalRankRewardValue reward, int seasonCode)
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

		public RaidBossConfig.SeasonalRankRewardValue GetRankRewardInfo()
		{
			return null;
		}
	}
}
