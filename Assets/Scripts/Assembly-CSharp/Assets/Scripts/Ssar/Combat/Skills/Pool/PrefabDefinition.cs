using Assets.Scripts.Ssar.Common.Pooling;

namespace Assets.Scripts.Ssar.Combat.Skills.Pool
{
	public class PrefabDefinition : Definition
	{
		private int id;

		private PrefabItem prefabItem;

		public PrefabDefinition(int id, PrefabItem prefabItem)
		{
		}

		public int Id()
		{
			return 0;
		}

		public int Size()
		{
			return 0;
		}

		public bool Expandable()
		{
			return false;
		}

		public Item Object()
		{
			return null;
		}
	}
}
