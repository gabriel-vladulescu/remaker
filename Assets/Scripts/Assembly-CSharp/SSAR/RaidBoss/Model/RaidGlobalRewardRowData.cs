using System.Collections.Generic;
using Scripts.Config;

namespace Ssar.RaidBoss.Model
{
	public class RaidGlobalRewardRowData
	{
		private List<ItemInfo> rewards;

		private string text;

		private RaidBossConfig.GlobalReward globalReward;

		private int seasonCode;

		public RaidGlobalRewardRowData(RaidBossConfig.GlobalReward globalReward, int seasonCode, int baseKill)
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

		public RaidBossConfig.GlobalReward GetGlobalRewardInfo()
		{
			return null;
		}
	}
}
