using Scripts.Config;
using Ssar.RaidBoss.Battle;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class RaidBossModeFindMonsterLevelStats : IFindLevelStats
	{
		private int groupId;

		private int subId;

		private int level;

		private ScenarioDifficulty scenarioDifficulty;

		private ConfigManager configManager;

		private RaidMonsterStatsLogic monsterStatsLogic;

		public RaidBossModeFindMonsterLevelStats(int groupId, int subId, int level, ScenarioDifficulty scenarioDifficulty, ConfigManager configManager, RaidMonsterStatsLogic monsterStatsLogic)
		{
		}

		public HeroLevelStats HeroLevelStats()
		{
			return null;
		}
	}
}
