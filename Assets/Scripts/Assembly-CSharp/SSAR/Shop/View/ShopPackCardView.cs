using Assets.Scripts.Ssar.Shop.Model;
using SSAR.Shop.Enum;
using Scripts.Config;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class ShopPackCardView : AbsShopCardView
	{
		public UILabel lb_title;

		public UILabel lb_price;

		public UILabel lb_priceBase;

		public UILabel lb_available;

		public UILabel lb_sale;

		public UISprite sp_icon;

		public GameObject go_discount;

		private AbsCardViewParameter _shopAbsProductInfo;

		private void Awake()
		{
		}

		public void Show(BundlePackageProductInfo productInfo, ShopTabType shopTabType)
		{
		}

		public void Show(BundleCardViewParamater productInfo)
		{
		}

		public void Show(AbsCardViewParameter productInfo)
		{
		}

		private string GetTextAvailable(BundlePackageProductInfo productInfo)
		{
			return null;
		}

		private bool IsReachLimit(BundlePackageProductInfo productInfo)
		{
			return false;
		}

		private int PurchasedCount(BundlePackageProductInfo productInfo)
		{
			return 0;
		}

		private BundlePackageBoughtData GetBundlePackageBoughtData()
		{
			return null;
		}

		public void Hide()
		{
		}

		private void Click(GameObject o)
		{
		}
	}
}
