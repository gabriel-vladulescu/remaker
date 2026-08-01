using System.Collections.Generic;
using LitJson;

namespace Scripts.Config
{
	public class ShopNewSubscribePackageConfig : IConfig
	{
		[JsonInclude]
		private Dictionary<string, NewSubscribePackageProductInfo> productInfos;

		private Dictionary<string, List<SubscribePackageRewardInfo>> _dictPackageRewards;

		public void OnMapValue(string content)
		{
		}

		public List<string> GetAllSkus()
		{
			return null;
		}

		public List<NewSubscribePackageProductInfo> GetProductInfos()
		{
			return null;
		}

		public bool FindShopPackProductInfoBySku(string sku, ref NewSubscribePackageProductInfo productInfo)
		{
			return false;
		}

		public NewSubscribePackageProductInfo GetProductInfoWithProductId(int productId)
		{
			return null;
		}

		public List<SubscribePackageRewardInfo> GetRewardInfos(int productId)
		{
			return null;
		}

		private void Setup(string content)
		{
		}

		private int Comparer(NewSubscribePackageProductInfo a, NewSubscribePackageProductInfo b)
		{
			return 0;
		}

		public List<ItemInfo> GetRewardInfo(int productId, int day)
		{
			return null;
		}

		public List<List<ItemInfo>> GetAllReward(int productId)
		{
			return null;
		}
	}
}
