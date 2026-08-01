using Scripts.Config;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class ShopSoulCardView : AbsShopCardView
	{
		public UILabel lb_name;

		public UILabel lb_cost;

		public UISprite sp_icon;

		public UILabel lb_bonus;

		public GameObject btn_purchase;

		private ShopSoulProductInfo productInfo;

		private void Awake()
		{
		}

		public void Show(int index, ShopSoulProductInfo productInfo)
		{
		}

		public void Hide()
		{
		}

		private void Buy(GameObject o)
		{
		}
	}
}
