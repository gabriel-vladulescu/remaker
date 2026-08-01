using Assets.Scripts.Ssar.DataManager;
using Scripts.Config;

namespace Ssar.Achievement.Model
{
	public class AchievementUnlockNotifyManager
	{
		private AchievementData achievementData;

		private JsonAchievementConfig config;

		public AchievementUnlockNotifyManager(AchievementData achievementData, JsonAchievementConfig jsonAchievementConfig)
		{
		}

		public void OnUpdateMetricProgress(int metricId)
		{
		}

		private void AddToQueue(JsonAchievementConfig.AchievementItem achievementItem)
		{
		}
	}
}
