using System.Collections.Generic;
using SSAR.Equipment.View;
using UnityEngine;

namespace Ssar.Craft.View
{
	public class CraftingInventoryItemView : BaseInventoryItemView
	{
		public UILabel lb_name;

		public UILabel lb_leftTop;

		public UILabel lb_rightTop;

		public UILabel lb_tier;

		public UILabel lb_quantity;

		public UISprite sp_rarity;

		public UISprite sp_icon;

		public UITable table_rune;

		public UISprite[] skillIcon;

		public GameObject wg_select;

		public GameObject wg_tier;

		private AwakenLevelView awakenLevelView;

		protected override void Awake()
		{
		}

		protected override void OnShow(ICollectData collectData)
		{
		}

		private void HideEquipmentElements()
		{
		}

		protected override List<IOverlay> Overlay()
		{
			return null;
		}

		private void ClickItem(GameObject go)
		{
		}

		private void ClickEquipment()
		{
		}

		internal void Refresh()
		{
		}
	}
}
