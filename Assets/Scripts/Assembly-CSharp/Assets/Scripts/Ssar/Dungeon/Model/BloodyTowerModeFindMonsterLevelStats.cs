using Scripts.Config;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class BloodyTowerModeFindMonsterLevelStats : IFindLevelStats
	{
		private int groupId;

		private int subId;

		private int level;

		private int floor;

		private ConfigManager configManager;

		public BloodyTowerModeFindMonsterLevelStats(int groupId, int subId, int level, int floor, ConfigManager configManager)
		{
		}

		public HeroLevelStats HeroLevelStats()
		{
			return null;
		}
	}
}
