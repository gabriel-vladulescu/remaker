using System;
using System.Collections.Generic;
using Assets.Scripts.Ssar.Common.Pooling;
using Assets.Scripts.Ssar.Common.System.Resources;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Pool
{
	public class PreloadPool
	{
		public class PrefabPathMarker : Attribute
		{
		}

		private ResourcesLoader resourcesLoader;

		private Action onPreloadComplete;

		private List<string> prefabPaths;

		private Assets.Scripts.Ssar.Common.Pooling.Pool pool;

		private PrefabDefinition[] definitions;

		private PrefabItemFactory factory;

		private List<PrefabItem> readyItems;

		public PreloadPool(ResourcesLoader resourcesLoader, Action onPreloadComplete, List<string> prefabPaths)
		{
		}

		public void AddPreload(List<string> prefabPaths, Action onPreloadComplete)
		{
		}

		public void Preload()
		{
		}

		public GameObject GetPrefabByPath(string prefabPath)
		{
			return null;
		}

		public PrefabItem[] ReadyItems()
		{
			return null;
		}

		private void OnProductReady(PrefabItem item, Definition definition, int itemIndex)
		{
		}
	}
}
