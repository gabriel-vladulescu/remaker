using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Common.Pooling
{
	public class Pool
	{
		private class ObtainOperation
		{
			private class Result
			{
				private bool found;

				private Item item;

				public Result(bool found, Item item)
				{
				}

				public bool Found()
				{
					return false;
				}

				public Item Item()
				{
					return null;
				}
			}

			private Dictionary<int, Definition> definitions;

			private Dictionary<int, List<Item>> itemsById;

			public ObtainOperation(Dictionary<int, Definition> definitions, Dictionary<int, List<Item>> itemsById)
			{
			}

			public T Act<T>(int id, ItemFactory itemFactory, out bool newlyCreated, bool createNew = false) where T : Item
			{
				newlyCreated = default(bool);
				return default(T);
			}

			private void CheckMaxSizeReachedForNonExpandableDefinition<T>(int id, Definition definition) where T : Item
			{
			}

			private Item CreateNew(int id, ItemFactory itemFactory)
			{
				return null;
			}

			private Result FindInactiveItem(int id)
			{
				return null;
			}

			private void CreateNewItemCollectionIfNotExisted(int id)
			{
			}

			private static void CheckItemFactoryNotNull(ItemFactory itemFactory)
			{
			}

			private void CheckDefinitionExistedForId(int id)
			{
			}
		}

		private readonly Config config;

		private Dictionary<int, Definition> definitions;

		private Dictionary<int, List<Item>> itemsById;

		private Display display;

		public Pool(Config config)
		{
		}

		public Pool(Config config, Display display)
		{
		}

		public T Obtain<T>(int id, ItemFactory itemFactory, bool createNew = false) where T : Item
		{
			return default(T);
		}

		public List<Item> ShowAllItems()
		{
			return null;
		}

		private void UpdateDefinitionsIfMissing(int id)
		{
		}

		public void Return(Item item)
		{
		}
	}
}
