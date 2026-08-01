using System.Collections.Generic;
using Assets.Scripts.Ssar.Common.Pooling;
using UnityEngine;

namespace Ssar.BattleSystem.EntityTemplate
{
	public class MonsterPool
	{
		private Pool pool;

		private Config config;

		private Dictionary<GameObject, int> itemIdByPrefab;

		public MonsterPool(List<GameObject> prefabs)
		{
		}

		public GameObject Obtain(GameObject prefab, bool createNew = false)
		{
			return null;
		}

		public void Return(MonsterGameObjectItem item, bool triggerRecord = true)
		{
		}

		public void WarmUp(Dictionary<GameObject, int> pools)
		{
		}
	}
}
