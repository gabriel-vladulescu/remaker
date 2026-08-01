using System.Collections.Generic;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using UnityEngine;

namespace Ssar.Ancient.View
{
	public class AncientEnhanceInventoryItemView : BaseInventoryItemView
	{
		public UILabel lb_name;

		public UILabel lb_leftTop;

		public UILabel lb_rightTop;

		public UILabel lb_tier;

		public UISprite sp_rarity;

		public UISprite sp_icon;

		public GameObject wg_tier;

		public GameObject wg_select;

		private AwakenLevelView awakenLevelView;

		protected override void Awake()
		{
		}

		protected override void OnShow(ICollectData collectData)
		{
		}

		protected override List<IOverlay> Overlay()
		{
			return null;
		}

		private void ClickItem(GameObject go)
		{
		}

		internal void Refresh(EquipmentCollectData e)
		{
		}
	}
}
