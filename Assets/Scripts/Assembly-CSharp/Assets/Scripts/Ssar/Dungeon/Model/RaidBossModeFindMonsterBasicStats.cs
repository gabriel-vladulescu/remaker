using Scripts.Config;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class RaidBossModeFindMonsterBasicStats : IFindBasicStats
	{
		private int groupId;

		private int subId;

		private ConfigManager configManager;

		public RaidBossModeFindMonsterBasicStats(int groupId, int subId, ConfigManager configManager)
		{
		}

		public HeroBasicStats HeroBasicStats()
		{
			return null;
		}
	}
}
