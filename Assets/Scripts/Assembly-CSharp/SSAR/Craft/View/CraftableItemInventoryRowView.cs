using System.Collections.Generic;

namespace Ssar.Craft.View
{
	public class CraftableItemInventoryRowView : SimpleWraptContentRowView
	{
		public UITable Table;

		public int columns;

		private List<CraftableItemInventoryItemView> ItemViews;

		protected override void Awake()
		{
		}

		private void Init()
		{
		}

		public override void OnShow(WrapContentData data, int index)
		{
		}

		public override void Hide()
		{
		}
	}
}
