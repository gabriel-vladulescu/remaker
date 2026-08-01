using System.Collections.Generic;

namespace Scripts.Config
{
	public class GiftCodeRewardConfig : IConfig
	{
		public Dictionary<string, Reward> rewards;

		public void OnMapValue(string content)
		{
		}

		public List<Reward> FindRewardsById(int rewardId)
		{
			return null;
		}
	}
}
