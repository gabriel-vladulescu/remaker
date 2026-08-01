using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.Shop.Model
{
	public class OldLevelUpPackageCardViewParameter : AbsCardViewParameter
	{
		private ShopPackProductInfo productInfo;

		public OldLevelUpPackageCardViewParameter(ShopPackProductInfo productInfo)
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
