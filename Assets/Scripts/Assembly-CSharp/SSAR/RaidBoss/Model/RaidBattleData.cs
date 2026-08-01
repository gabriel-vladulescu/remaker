using System.Collections.Generic;
using Artemis;

namespace Ssar.RaidBoss.Model
{
	public class RaidBattleData
	{
		public class Record
		{
			public int id;

			public int level;

			public string name;

			public float totalDamage;
		}

		private EntityWorld entityWorld;

		private Dictionary<int, Record> records;

		private int mainCharacterId;

		public RaidBattleData(EntityWorld entityWorld)
		{
		}

		internal void CreatRecord(Entity entity, MainCharacterData mainCharacterData, bool isMain = false)
		{
		}

		internal void OnEntityDealDamage(int id, float damage)
		{
		}

		internal List<Record> GetContributorRecords()
		{
			return null;
		}

		internal List<Record> GetSortedContributorRecords()
		{
			return null;
		}

		internal int GetMainCharacterRank()
		{
			return 0;
		}

		private Record GetContributorRecord(int id)
		{
			return null;
		}

		private int RecordComparer(Record a, Record b)
		{
			return 0;
		}
	}
}
