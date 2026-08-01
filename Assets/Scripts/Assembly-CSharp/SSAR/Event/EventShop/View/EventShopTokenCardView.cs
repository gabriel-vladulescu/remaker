using SSAR.Shop.View;
using Scripts.Config;
using UnityEngine;

namespace Ssar.Event.EventShop.View
{
	public class EventShopTokenCardView : AbsShopCardView
	{
		public UILabel lb_name;

		public UILabel lb_cost;

		public UISprite sp_icon;

		public UILabel lb_bonus;

		public UITable table_title;

		public GameObject btn_purchase;

		private EventShopTokenProductInfo productInfo;

		private void Awake()
		{
		}

		private void Buy(GameObject go)
		{
		}

		public void Show(int index, EventShopTokenProductInfo productInfo)
		{
		}

		public void Hide()
		{
		}
	}
}
