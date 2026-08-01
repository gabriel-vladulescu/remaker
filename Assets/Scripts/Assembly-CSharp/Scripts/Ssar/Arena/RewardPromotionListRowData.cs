using System.Collections.Generic;
using Scripts.Config;

namespace Scripts.Ssar.Arena
{
	public class RewardPromotionListRowData
	{
		private List<ItemInfo> reward;

		private string text;

		private PromotionRankRewardValue rankRewardValue;

		public RewardPromotionListRowData(PromotionRankRewardValue rankHigher, PromotionRankRewardValue currentRank)
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

		public PromotionRankRewardValue GetRankRewardInfo()
		{
			return null;
		}
	}
}
