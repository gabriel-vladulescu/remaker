using Artemis.System;
using Scripts.Config;

namespace Ssar.DailyChallenge.Systems
{
	public class ChallengeRewardSystem : EntitySystemWithTime
	{
		private ScenarioDifficulty curDifficulty;

		public ChallengeRewardSystem(ScenarioDifficulty difficulty)
		{
		}

		protected override void Process(float deltaTime)
		{
		}

		private void OnClearStage(int stageOrder)
		{
		}

		private ItemInfo[] GenerateReward(DailyChallengeRewardConfig.Pool pool)
		{
			return null;
		}

		private void ReceiveReward(ItemInfo itemInfo)
		{
		}

		private void NotifyReceiveItem(ItemInfo itemInfo)
		{
		}
	}
}
