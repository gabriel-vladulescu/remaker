using System;
using Assets.Scripts.Ssar.Dungeon.Spawn;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class DefaultMonsterSpawner : MonsterSpawner
	{
		private GameObjectSpawner spawner;

		public DefaultMonsterSpawner(GameObjectSpawner spawner)
		{
		}

		public void Spawn(string id, float x, float y, Action<GameObject, int> onSpawnSuccess)
		{
		}
	}
}
