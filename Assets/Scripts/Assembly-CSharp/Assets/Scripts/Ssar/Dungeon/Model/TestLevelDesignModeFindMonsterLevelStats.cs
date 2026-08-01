using Scripts.Config;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class TestLevelDesignModeFindMonsterLevelStats : IFindLevelStats
	{
		private int groupId;

		private int subId;

		private int level;

		private ScenarioDifficulty scenarioDifficulty;

		private ConfigManager configManager;

		public TestLevelDesignModeFindMonsterLevelStats(int groupId, int subId, int level, ScenarioDifficulty scenarioDifficulty, ConfigManager configManager)
		{
		}

		public HeroLevelStats HeroLevelStats()
		{
			return null;
		}
	}
}
