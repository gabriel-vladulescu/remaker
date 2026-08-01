using System;
using System.Collections.Generic;
using Assets.Scripts.Ssar.Combat.Skills.Pool;
using Assets.Scripts.Ssar.Common.Pooling;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Effects.Pool
{
	public class EffectPool
	{
		private class EffectGameObjectItemFactory : GameObjectItemFactory
		{
			private EffectPool ep;

			public EffectGameObjectItemFactory(EffectPool ep)
			{
			}

			public override Item Produce(Definition definition, int itemIndex)
			{
				return null;
			}
		}

		private PrefabItem[] effectPrefabs;

		private Assets.Scripts.Ssar.Common.Pooling.Pool pool;

		private Assets.Scripts.Ssar.Common.Pooling.Config config;

		private Dictionary<string, int> itemIdByPrefabPath;

		private Dictionary<GameObject, int> itemIdByPrefab;

		private List<GameObjectItem> gameObjectItems;

		private Action<GameObjectItem> obtainedItemCallback;

		public EffectPool(PrefabItem[] effectPrefabs)
		{
		}

		private void Init()
		{
		}

		public void UpdateList(PrefabItem[] m_effectPrefabs)
		{
		}

		private bool HasItem(List<PrefabItem> list, PrefabItem newItem)
		{
			return false;
		}

		public void ListenToObtaining(Action<GameObjectItem> callback)
		{
		}

		public void UnlistenToObtaining(Action<GameObjectItem> callback)
		{
		}

		public List<PrefabItem> Warmup()
		{
			return null;
		}

		public GameObject Obtain(string prefabPath, GameObject prefab)
		{
			return null;
		}

		public GameObject Obtain(string prefabPath)
		{
			return null;
		}

		public GameObject Obtain(GameObject prefab)
		{
			return null;
		}

		public void Return(GameObjectItem item)
		{
		}

		public List<GameObjectItem> ShowAllGameObjectItems()
		{
			return null;
		}
	}
}
