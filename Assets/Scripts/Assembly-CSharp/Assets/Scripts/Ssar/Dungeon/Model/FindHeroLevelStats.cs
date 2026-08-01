using Scripts.Config;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class FindHeroLevelStats : IFindLevelStats
	{
		private int groupId;

		private int subId;

		private int level;

		private HeroConfig heroConfig;

		public FindHeroLevelStats(int groupId, int subId, int level, HeroConfig heroConfig)
		{
		}

		public HeroLevelStats HeroLevelStats()
		{
			return null;
		}
	}
}
