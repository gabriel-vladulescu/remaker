using System.Collections.Generic;
using Assets.Scripts.Ssar.DataManager;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Achievement.View
{
	public class AchievementNotify
	{
		private List<JsonAchievementConfig.AchievementItem> achievementItems;

		private JsonAchievementConfig jsonAchievementConfig;

		private AchievementData achievementData;

		public bool IsNotify()
		{
			return false;
		}
	}
}
