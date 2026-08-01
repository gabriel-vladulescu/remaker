using SSAR.Shop.Enum;
using Scripts.Config;
using Ssar.Analytics.Metrics.Firebase;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class BundleCardViewParamater : AbsCardViewParameter
	{
		private readonly BundlePackageProductInfo _productInfo;

		private readonly ItemLocationId itemLocationId;

		private readonly ShopTabType shopTabType;

		public BundlePackageProductInfo ProductInfo => null;

		public BundleCardViewParamater(BundlePackageProductInfo productInfo, ItemLocationId itemLocationId, ShopTabType shopTabType)
		{
		}

		public string Title()
		{
			return null;
		}

		public string Icon()
		{
			return null;
		}

		public void OnClick(GameObject o)
		{
		}

		public void OnCustomizeIcon(UISprite spriteIcon)
		{
		}
	}
}
