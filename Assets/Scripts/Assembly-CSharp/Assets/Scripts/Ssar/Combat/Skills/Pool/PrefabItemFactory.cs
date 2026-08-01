using System;
using Assets.Scripts.Ssar.Common.Pooling;
using Assets.Scripts.Ssar.Common.System.Resources;

namespace Assets.Scripts.Ssar.Combat.Skills.Pool
{
	public class PrefabItemFactory : ItemFactory
	{
		private ResourcesLoader resourcesLoader;

		private Action<PrefabItem, Definition, int> onProductReady;

		public PrefabItemFactory(ResourcesLoader resourcesLoader, Action<PrefabItem, Definition, int> onProductReady)
		{
		}

		public Item Produce(Definition definition, int itemIndex)
		{
			return null;
		}
	}
}
