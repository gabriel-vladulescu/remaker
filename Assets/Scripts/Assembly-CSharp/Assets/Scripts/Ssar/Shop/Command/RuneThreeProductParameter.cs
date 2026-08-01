using System.Collections.Generic;
using Scripts.Config;
using Ssar.Analytics.Metrics.Firebase;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class RuneThreeProductParameter : AbsShowPackageThreeProductParameter
	{
		private class Info
		{
			public List<BundlePackageProductInfo> ProductInfos { get; private set; }

			public string Category { get; private set; }

			public Info(List<BundlePackageProductInfo> productInfos, string category)
			{
			}
		}

		private List<Info> infos;

		private ShopConfig shopConfig;

		private int curIndex;

		private void Init()
		{
		}

		private int Comparer(BundlePackageProductInfo a, BundlePackageProductInfo b)
		{
			return 0;
		}

		private int Comparer(Info a, Info b)
		{
			return 0;
		}

		public override void Close()
		{
		}

		public override List<BundlePackageProductInfo> BundlePackageProductInfos()
		{
			return null;
		}

		public override string Category()
		{
			return null;
		}

		public override ItemLocationId ShownFrom()
		{
			return default(ItemLocationId);
		}

		public override bool EnableNext()
		{
			return false;
		}

		public override void Next()
		{
		}

		public override void Previous()
		{
		}

		private void UpdateIndex(int index)
		{
		}
	}
}
