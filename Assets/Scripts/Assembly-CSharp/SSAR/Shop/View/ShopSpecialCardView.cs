using Scripts.Config;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class ShopSpecialCardView : AbsShopCardView
	{
		public UILabel lb_name;

		public UILabel lb_cost;

		public UISprite sp_icon;

		public UILabel lb_bonus;

		public GameObject btn_purchase;

		private ShopSpecialProductInfo productInfo;

		private void Awake()
		{
		}

		public void Show(int index, ShopSpecialProductInfo productInfo)
		{
		}

		public void Hide()
		{
		}

		private string GetTitle(ShopSpecialProductInfo productInfo)
		{
			return null;
		}

		private void Buy(GameObject o)
		{
		}
	}
}
