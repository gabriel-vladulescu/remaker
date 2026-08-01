using System.Collections.Generic;
using Scripts.Config;

namespace SSAR.Shop.View
{
	public class ShopCrystalContainer : AbsShopContainer
	{
		private List<ShopCrystalProductInfo> productInfos;

		protected override void OnAwake()
		{
		}

		protected override void OnShow()
		{
		}

		protected override void OnHide()
		{
		}

		protected override string CardViewPath()
		{
			return null;
		}

		protected override int NumOfRowInstantiate()
		{
			return 0;
		}
	}
}
