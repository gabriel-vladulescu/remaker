using Scripts.Config;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class AdventureModeFindMonsterLevelStats : IFindLevelStats
	{
		private int groupId;

		private int subId;

		private int level;

		private ScenarioDifficulty scenarioDifficulty;

		private ConfigManager configManager;

		private double statScale;

		public AdventureModeFindMonsterLevelStats(int groupId, int subId, int level, ScenarioDifficulty scenarioDifficulty, ConfigManager configManager)
		{
		}

		public void SetStatScale(double scale)
		{
		}

		public HeroLevelStats HeroLevelStats()
		{
			return null;
		}
	}
}
