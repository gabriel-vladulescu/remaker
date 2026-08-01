using System.Collections.Generic;
using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public abstract class AbsShowAllPackageCmd : strange.extensions.command.impl.Command
	{
		private class Info
		{
			public List<BundlePackageProductInfo> ProductInfos { get; private set; }

			public string Category { get; private set; }

			public Info(List<BundlePackageProductInfo> productInfos, string category)
			{
			}
		}

		private ShopConfig shopConfig;

		public override void Execute()
		{
		}

		private void GetInfo(out BundlePackageProductInfo bundlePackageProductInfo, out string category, out List<BundlePackageProductInfo> list)
		{
			bundlePackageProductInfo = null;
			category = null;
			list = null;
		}

		private int Comparer(BundlePackageProductInfo a, BundlePackageProductInfo b)
		{
			return 0;
		}

		private int Comparer(Info a, Info b)
		{
			return 0;
		}

		protected abstract List<BundlePackageProductInfo> GetProductInfos();

		protected abstract void OnExcute();
	}
}
