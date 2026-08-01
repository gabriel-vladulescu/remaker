using Scripts.Config;

namespace Ssar.DailyChallenge.Logic.Reward
{
	public interface IChallengeRewardDropLogic
	{
		ItemInfo[] Drop(DailyChallengeRewardConfig.Reward rewardInfo);
	}
}
