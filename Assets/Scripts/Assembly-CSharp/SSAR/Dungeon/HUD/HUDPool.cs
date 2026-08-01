using System.Collections.Generic;
using Assets.Scripts.Ssar.Combat.Skills.Pool;
using Assets.Scripts.Ssar.Common.Pooling;
using UnityEngine;

namespace SSAR.Dungeon.HUD
{
	public class HUDPool
	{
		private List<PrefabItem> prefabs;

		private Pool pool;

		private Config config;

		private Dictionary<string, int> itemIdByPrefabPath;

		private Dictionary<GameObject, int> itemIdByPrefab;

		public HUDPool(List<PrefabItem> prefabs)
		{
		}

		private void Init()
		{
		}

		public GameObject Obtain(GameObject prefab)
		{
			return null;
		}

		public GameObject Obtain(string prefabPath)
		{
			return null;
		}

		public void Return(GameObjectItem item)
		{
		}

		public void Warmup(int initSize)
		{
		}
	}
}
