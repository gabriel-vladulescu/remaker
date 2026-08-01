using System.Collections.Generic;
using LitJson;

namespace Scripts.Config
{
	public class ShopNewLevelUpPackageConfig : IConfig
	{
		[JsonInclude]
		private Dictionary<string, NewLevelUpPackageProductInfo> productInfos;

		private Dictionary<string, List<LevelUpPackageRewardInfo>> _dictLevelUpReward;

		public void OnMapValue(string content)
		{
		}

		public List<NewLevelUpPackageProductInfo> GetProductInfosWithLevel(int characterLevel)
		{
			return null;
		}

		public bool FindPackageProductInfoBySku(string sku, ref NewLevelUpPackageProductInfo firstTimePurchaseProductInfo)
		{
			return false;
		}

		public bool FindPackageProductInfoByProductId(int productId, ref NewLevelUpPackageProductInfo firstTimePurchaseProductInfo)
		{
			return false;
		}

		public List<string> GetAllSkus()
		{
			return null;
		}

		public List<LevelUpPackageRewardInfo> GetRewardInfos(int productId)
		{
			return null;
		}

		private void Setup(string content)
		{
		}

		private int Comparer(NewLevelUpPackageProductInfo a, NewLevelUpPackageProductInfo b)
		{
			return 0;
		}

		private int Comparer(LevelUpPackageRewardInfo a, LevelUpPackageRewardInfo b)
		{
			return 0;
		}
	}
}
