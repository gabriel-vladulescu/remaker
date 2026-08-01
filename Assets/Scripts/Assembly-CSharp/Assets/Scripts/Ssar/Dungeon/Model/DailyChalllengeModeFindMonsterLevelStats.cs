using Scripts.Config;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class DailyChalllengeModeFindMonsterLevelStats : IFindLevelStats
	{
		private int groupId;

		private int subId;

		private int level;

		private ScenarioDifficulty scenarioDifficulty;

		private ConfigManager configManager;

		private int roundId;

		public DailyChalllengeModeFindMonsterLevelStats(int groupId, int subId, int level, ScenarioDifficulty scenarioDifficulty, ConfigManager configManager, int roundId)
		{
		}

		public HeroLevelStats HeroLevelStats()
		{
			return null;
		}

		private DailyChallengeConfig.Round GetRoundConfig()
		{
			return null;
		}
	}
}
