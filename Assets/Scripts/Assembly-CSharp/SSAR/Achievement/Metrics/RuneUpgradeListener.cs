using SSAR.SkillSystem.Model;
using SSAR.SkillSystem.Utils;
using Scripts.Config;

namespace Ssar.Achievement.Metrics
{
	public class RuneUpgradeListener
	{
		private AchievementLogic achievementLogic;

		private HeroConfig heroConfig;

		public RuneUpgradeListener(AchievementLogic achievementLogic, HeroConfig heroConfig)
		{
		}

		public void OnRuneUpgrade(SkillConfigId skillId, RuneType runeType, int before, int after)
		{
		}
	}
}
