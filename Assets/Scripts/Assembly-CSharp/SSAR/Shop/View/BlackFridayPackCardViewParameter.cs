using Scripts.Config;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class BlackFridayPackCardViewParameter : AbsCardViewParameter
	{
		public readonly BundlePackageProductInfo productInfo;

		public BlackFridayPackCardViewParameter(BundlePackageProductInfo productInfo)
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
