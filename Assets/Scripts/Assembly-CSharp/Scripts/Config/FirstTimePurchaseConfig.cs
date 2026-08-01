using System.Collections.Generic;
using LitJson;

namespace Scripts.Config
{
	public class FirstTimePurchaseConfig : IConfig
	{
		[JsonInclude]
		private Dictionary<string, FirstTimePurchaseProductInfo> productInfos;

		[JsonInclude]
		private Dictionary<string, FirstTimePurchaseProductRewardInfo> productRewards;

		private Dictionary<string, List<FirstTimePurchaseProductRewardInfo>> packageReward;

		public void OnMapValue(string content)
		{
		}

		public List<FirstTimePurchaseProductInfo> GetProductInfos(int characterLevel)
		{
			return null;
		}

		public List<FirstTimePurchaseProductRewardInfo> GetRewardInfos(int productId)
		{
			return null;
		}

		public bool FindPackageProductInfoBySku(string sku, ref FirstTimePurchaseProductInfo firstTimePurchaseProductInfo)
		{
			return false;
		}

		public List<string> GetAllSkus()
		{
			return null;
		}

		private int Comparer(FirstTimePurchaseProductInfo a, FirstTimePurchaseProductInfo b)
		{
			return 0;
		}

		private int ComparerBundlePackageReward(FirstTimePurchaseProductRewardInfo a, FirstTimePurchaseProductRewardInfo b)
		{
			return 0;
		}

		private void Setup(string content)
		{
		}
	}
}
