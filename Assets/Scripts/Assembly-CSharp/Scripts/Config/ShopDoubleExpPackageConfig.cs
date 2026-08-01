using System.Collections.Generic;

namespace Scripts.Config
{
	public class ShopDoubleExpPackageConfig : IConfig
	{
		public Dictionary<string, DoubleExpPackageProductInfo> productInfos;

		public void OnMapValue(string content)
		{
		}

		public List<DoubleExpPackageProductInfo> GetProductInfos()
		{
			return null;
		}

		public List<string> GetAllSkus()
		{
			return null;
		}

		public bool FindShopPackProductInfoBySku(string sku, ref DoubleExpPackageProductInfo productInfo)
		{
			return false;
		}

		private int Comparer(DoubleExpPackageProductInfo a, DoubleExpPackageProductInfo b)
		{
			return 0;
		}
	}
}
