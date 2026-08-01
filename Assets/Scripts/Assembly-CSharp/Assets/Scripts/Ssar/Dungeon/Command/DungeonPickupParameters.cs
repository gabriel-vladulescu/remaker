using System;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class DungeonPickupParameters
	{
		public ItemInfo itemInfo;

		public Action onHide;

		public DungeonPickupParameters(ItemInfo itemInfo, Action onHide)
		{
		}
	}
}
