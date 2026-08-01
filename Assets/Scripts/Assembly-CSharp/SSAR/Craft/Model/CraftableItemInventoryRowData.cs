using System.Collections.Generic;

namespace Ssar.Craft.Model
{
	public class CraftableItemInventoryRowData : WrapContentData
	{
		public List<CraftableItem> Items;

		public CraftableItemInventoryRowData(List<CraftableItem> items)
		{
		}
	}
}
