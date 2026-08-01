using Scripts.Config;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class BloodyTowerModeFindMonsterBasicStats : IFindBasicStats
	{
		private int groupId;

		private int subId;

		private ConfigManager configManager;

		public BloodyTowerModeFindMonsterBasicStats(int groupId, int subId, ConfigManager configManager)
		{
		}

		public HeroBasicStats HeroBasicStats()
		{
			return null;
		}
	}
}
