using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Ssar.Dungeon.Model;

namespace SSAR.Dungeon.Model
{
	public class DungeonMonsterKilledManager
	{
		private Dictionary<SpawnSource, int> dictionary;

		private int bossKilled;

		public void DamageCalculationSystemOnEntityDeathEvent(Entity entity)
		{
		}

		public int GetListMonsterKilledExcluteSpawner()
		{
			return 0;
		}

		public int GetListMonsterKilled()
		{
			return 0;
		}

		public int GetBossKilled()
		{
			return 0;
		}

		public int GetMonsterKilledExcludeBoss()
		{
			return 0;
		}
	}
}
