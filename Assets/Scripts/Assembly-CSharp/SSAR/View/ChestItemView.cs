using SSAR.Equipment.View;
using UnityEngine;

namespace SSAR.View
{
	public class ChestItemView : BaseInventoryItemView
	{
		public UILabel lb_name;

		public UILabel lb_quantity;

		public UISprite sp_rarity;

		public UISprite sp_icon;

		protected override void Awake()
		{
		}

		protected override void OnShow(ICollectData collectData)
		{
		}

		private void ClickItem(GameObject o)
		{
		}
	}
}
