using System.Collections.Generic;
using Scripts.Config;

namespace SSAR.Shop.View
{
	public class ShopTabHotContainer : AbsShopContainer
	{
		protected override void OnAwake()
		{
		}

		protected override void OnShow()
		{
		}

		private List<AbsCardViewParameter> AllPack()
		{
			return null;
		}

		private List<AbsCardViewParameter> Bundle()
		{
			return null;
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

		public static int Comparer(BundlePackageProductInfo a, BundlePackageProductInfo b)
		{
			return 0;
		}
	}
}
