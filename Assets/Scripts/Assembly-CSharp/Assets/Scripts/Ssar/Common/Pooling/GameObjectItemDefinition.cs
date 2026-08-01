using System;

namespace Assets.Scripts.Ssar.Common.Pooling
{
	[Serializable]
	public class GameObjectItemDefinition : Definition
	{
		public int id;

		public int size;

		public bool expandable;

		public GameObjectItem gameObjectItem;

		public GameObjectItemDefinition()
		{
		}

		public GameObjectItemDefinition(int id, int size, bool expandable, GameObjectItem gameObjectItem)
		{
		}

		public int Id()
		{
			return 0;
		}

		public bool Expandable()
		{
			return false;
		}

		public int Size()
		{
			return 0;
		}

		public Item Object()
		{
			return null;
		}
	}
}
