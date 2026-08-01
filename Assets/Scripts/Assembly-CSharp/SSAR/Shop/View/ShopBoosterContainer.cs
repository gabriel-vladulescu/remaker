using System.Collections.Generic;
using Scripts.Config;

namespace SSAR.Shop.View
{
	public class ShopBoosterContainer : AbsShopContainer
	{
		private List<ShopSpecialProductInfo> productInfos;

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
