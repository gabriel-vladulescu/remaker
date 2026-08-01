using Scripts.Config;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class FindHeroBasicStats : IFindBasicStats
	{
		private int groupId;

		private int subId;

		private HeroConfig heroConfig;

		public FindHeroBasicStats(int groupId, int subId, HeroConfig heroConfig)
		{
		}

		public HeroBasicStats HeroBasicStats()
		{
			return null;
		}
	}
}
