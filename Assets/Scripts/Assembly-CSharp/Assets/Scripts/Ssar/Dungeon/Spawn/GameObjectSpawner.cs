using System;
using Assets.Scripts.Ssar.Dungeon.Model;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Spawn
{
	public class GameObjectSpawner
	{
		public virtual GameObject SpawnCharacter()
		{
			return null;
		}

		public virtual GameObject SpawnMonster(string id)
		{
			return null;
		}

		public virtual GameObject SpawnMonster(string id, float spawnX, float spawnY, SpawnSource spawnSource, Action<GameObject, int> onSpawnSuccess)
		{
			return null;
		}
	}
}
