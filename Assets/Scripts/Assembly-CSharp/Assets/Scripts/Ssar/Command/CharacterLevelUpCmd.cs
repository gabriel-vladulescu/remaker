using Ssar.Achievement;
using Ssar.Analytics.Metrics;
using Ssar.Event.SevenDaysCampaign;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class CharacterLevelUpCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public CharacterLevelUpParameter Parameter { get; set; }

		[Inject]
		public AchievementLogic achievementLogic { get; set; }

		[Inject]
		public CampaignLogic campaignLogic { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		public void NotifyNewSkillUnlock(int levelBefore, int levelAfter)
		{
		}

		private void AddReward(int levelbefore, int levelAfter)
		{
		}

		private void CheckUnLockBloodyTower(int level)
		{
		}

		private void CheckUnlockRaid()
		{
		}

		private void CheckNotifyFirstTopUpHasNewItem(int levelBefore, int levelAfter)
		{
		}

		private void MarketingMetric(int level, MainCharacterData mainCharacterData)
		{
		}
	}
}
