using Assets.Scripts.Config.Stats;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class MobSpawnInfo
	{
		public static readonly string SPAWNER;

		public Vector3 position;

		public int groupId;

		public int subId;

		public int level;

		public int ticketId;

		public SpawnSource spawnSource;

		public MonsterData monsterData;

		public MobSpawnInfo(Vector3 position, int groupId, int subId, int level, int ticketId, SpawnSource source)
		{
		}

		public MobSpawnInfo(Vector3 position, int groupId, int subId, int level)
		{
		}

		public MobSpawnInfo(Vector3 position, MonsterData monsterData)
		{
		}
	}
}
