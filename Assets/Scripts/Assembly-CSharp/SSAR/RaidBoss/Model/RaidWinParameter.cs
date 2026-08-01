using System.Collections.Generic;
using SSAR.Dungeon.Model;
using Scripts.Config;

namespace Ssar.RaidBoss.Model
{
	public class RaidWinParameter : DungeonWinParameter
	{
		public RaidBossConfig.Room room;

		public RaidDifficulty difficulty;

		public List<RaidWinRankInfo> rankInfos;

		public RaidWinParameter(string name, int expBefore, RaidBossConfig.Room room, int expCollected, int expBonus, int soulCollected, int soulBonus, int damageTaken, int battleTime, List<RaidWinRankInfo> rankInfos, List<ItemInfo> rewardInfos = null)
			: base(null, 0, 0, 0, 0, 0, 0, 0, 0)
		{
		}
	}
}
