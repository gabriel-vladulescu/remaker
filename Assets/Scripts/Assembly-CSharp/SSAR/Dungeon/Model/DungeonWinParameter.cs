using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon;
using Scripts.Config;

namespace SSAR.Dungeon.Model
{
	public class DungeonWinParameter
	{
		public IDungeonGetStarRule[] StarRules;

		public int dungeonId;

		public int star;

		public int battleTime;

		public string name;

		public int expBefore;

		public int expCollected;

		public int expBonus;

		public int soulCollected;

		public int soulBonus;

		public int damageTaken;

		public List<ItemInfo> rewards;

		public MemoryShardInfo memoryShardInfo;

		public bool isDoubleExpBuff;

		public DungeonWinParameter(string name, int expBefore, int dungeonId, int expCollected, int expBonus, int soulCollected, int soulBonus, int damageTaken, int battleTime, IDungeonGetStarRule star1 = null, IDungeonGetStarRule star2 = null, IDungeonGetStarRule star3 = null, List<ItemInfo> rewardInfos = null, MemoryShardInfo memoryShardInfo = null)
		{
		}

		private IDungeonGetStarRule[] Sort(IDungeonGetStarRule[] rules)
		{
			return null;
		}

		private int Comparer(IDungeonGetStarRule a, IDungeonGetStarRule b)
		{
			return 0;
		}
	}
}
