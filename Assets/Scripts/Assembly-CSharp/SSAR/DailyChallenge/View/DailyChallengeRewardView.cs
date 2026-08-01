using Scripts.Config;
using UnityEngine;

namespace Ssar.DailyChallenge.View
{
	public class DailyChallengeRewardView : MonoBehaviour
	{
		public GameObject container;

		public UILabel lbRound;

		private DungeonRewardView rewardView;

		private void Awake()
		{
		}

		internal void Show(DailyChallengeRewardConfig.Pool pool)
		{
		}

		internal void Hide()
		{
		}

		private ItemInfo ValidateReward(DailyChallengeRewardConfig.Reward reward)
		{
			return null;
		}

		private string GetQuantityText(DailyChallengeRewardConfig.Reward[] rewards)
		{
			return null;
		}
	}
}
