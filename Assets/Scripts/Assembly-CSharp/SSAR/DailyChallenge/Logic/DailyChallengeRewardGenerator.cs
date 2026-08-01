using Scripts.Config;
using Ssar.DailyChallenge.Logic.Reward;

namespace Ssar.DailyChallenge.Logic
{
	public class DailyChallengeRewardGenerator
	{
		private DailyChallengeRewardConfig config;

		private DailyChallengeRewardConfig.Pool rewardPool;

		public DailyChallengeRewardGenerator(DailyChallengeRewardConfig config, DailyChallengeRewardConfig.Pool rewardPool)
		{
		}

		public ItemInfo[] Generate()
		{
			return null;
		}

		private int GenerateRewardId()
		{
			return 0;
		}

		private IChallengeRewardDropLogic GetDropLogic(ItemType itemType)
		{
			return null;
		}
	}
}
