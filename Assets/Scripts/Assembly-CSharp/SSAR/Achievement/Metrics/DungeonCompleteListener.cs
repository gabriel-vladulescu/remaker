using Scripts.Config;
using Ssar.Event.SevenDaysCampaign;

namespace Ssar.Achievement.Metrics
{
	public class DungeonCompleteListener
	{
		private AchievementLogic achievementLogic;

		private CampaignLogic campaignLogic;

		private DungeonConfig dungeonConfig;

		public DungeonCompleteListener(AchievementLogic achievementLogic, CampaignLogic campaignLogic, DungeonConfig dungeonConfig)
		{
		}

		public void OnDungeonCompleted(int dungeonId)
		{
		}
	}
}
