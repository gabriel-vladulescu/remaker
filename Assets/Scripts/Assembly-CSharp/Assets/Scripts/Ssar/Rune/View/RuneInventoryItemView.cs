using System.Collections.Generic;
using SSAR.Equipment.View;
using UnityEngine;

namespace Assets.Scripts.Ssar.Rune.View
{
	public class RuneInventoryItemView : BaseInventoryItemView
	{
		public UILabel lb_name;

		public UILabel lb_quantity;

		public UISprite sp_rarity;

		public UISprite sp_icon;

		public GameObject wg_select;

		protected override void Awake()
		{
		}

		protected override void OnShow(ICollectData collectData)
		{
		}

		private void Click(GameObject o)
		{
		}

		protected override List<IOverlay> Overlay()
		{
			return null;
		}
	}
}
