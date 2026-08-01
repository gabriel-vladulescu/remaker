using Assets.Scripts.Ssar.Dungeon.Model;
using Scripts.Config;
using Scripts.Config.Stats;

namespace Assets.Scripts.Config.Stats
{
	public class MonsterData : AbsHeroData
	{
		private IFindBasicStats findBasicStats;

		private IFindLevelStats findLevelStats;

		public MonsterData(int groupId, int subId, int level, IFindLevelStats findLevelStats, IFindBasicStats findBasicStats)
			: base(0, 0, 0)
		{
		}

		public override EntityAbilities GetTotalStats()
		{
			return null;
		}

		public override HeroBasicStats GetHeroBasicStats()
		{
			return null;
		}

		public override HeroLevelStats GetHeroLevelStats()
		{
			return null;
		}
	}
}
