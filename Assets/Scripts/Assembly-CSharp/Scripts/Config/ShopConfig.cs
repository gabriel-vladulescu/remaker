using System.Collections.Generic;
using Assets.Scripts.Ssar.Shop.Model;

namespace Scripts.Config
{
	public class ShopConfig : IConfig
	{
		public Dictionary<string, ShopCrystalProductInfo> shopCrystal;

		public Dictionary<string, ShopSoulProductInfo> shopSoul;

		public Dictionary<string, ShopStaminaProductInfo> shopStamina;

		public Dictionary<string, ShopSpecialProductInfo> shopSpecial;

		public Dictionary<string, BundlePackageProductInfo> shopLimitedTime;

		public Dictionary<string, BundlePackageProductInfo> shopBeginner;

		public Dictionary<string, BundlePackageProductInfo> shopEquipment;

		public Dictionary<string, BundlePackageProductInfo> shopRune;

		public Dictionary<string, BundlePackageProductInfo> shopCostume;

		public Dictionary<string, BundlePackageProductInfo> shopPet;

		public Dictionary<string, BundlePackageProductInfo> shopSubscription;

		public Dictionary<string, BundlePackageProductInfo> shopGrowth;

		public Dictionary<string, ShopPackProductInfo> shopPack;

		public Dictionary<string, ShopTreasureProductInfo> shopTreasure;

		public Dictionary<string, LevelUpPackageRewardInfo> levelUpPackage;

		public Dictionary<string, SubscribePackageRewardInfo> subscriptionPackage;

		public Dictionary<string, BundlePackageProductInfo> shopBundles;

		public Dictionary<string, BundlePackageRewardInfo> bundleRewards;

		public Dictionary<string, BundlePackageCategoryInfo> bundleCategories;

		public Dictionary<string, UnlockAllCharactersPackageProductInfo> unlockAllCharactersPackage;

		public Dictionary<string, FlashSaleOreRuneBundleProductInfo> flashSaleOreRuneBundle;

		public Dictionary<string, int> categoryIds;

		private List<BundlePackageProductInfo> _shopLimitedTime;

		private List<BundlePackageProductInfo> _shopBeginner;

		private List<BundlePackageProductInfo> _shopEquipment;

		private List<BundlePackageProductInfo> _shopRune;

		private List<BundlePackageProductInfo> _shopCostume;

		private List<BundlePackageProductInfo> _shopPet;

		private List<BundlePackageProductInfo> _shopSubscription;

		private List<BundlePackageProductInfo> _shopGrowth;

		private List<ShopCrystalProductInfo> m_shopCrystal;

		private List<ShopSoulProductInfo> m_shopSoul;

		private List<ShopStaminaProductInfo> m_shopStamina;

		private List<ShopSpecialProductInfo> m_shopSpecial;

		private List<ShopPackProductInfo> m_shopPack;

		private List<ShopTreasureProductInfo> m_shopTreasure;

		private List<LevelUpPackageRewardInfo> m_levelUpPackageReward;

		private Dictionary<string, List<BundlePackageProductInfo>> m_shopBundle;

		private Dictionary<int, List<ItemInfo>> _subscriptionPackageRewardInfo;

		private Dictionary<int, List<BundlePackageRewardInfo>> m_bundlePackageRewardInfo;

		private Dictionary<string, BundlePackageCategoryInfo> m_categories;

		private List<BundlePackageProductInfo> listProductShowOne;

		private const string SHOP_ANCIENT_EQUIPMENT_CATEGORY = "ancient";

		private const string SHOP_ULTIMATE_ACCESSORY_CATEGORY = "accessory";

		private const string SHOP_BLACK_FRIDAY_CATEGORY = "shopblackfriday";

		public List<BundlePackageProductInfo> ShopLimitedTime => null;

		public List<BundlePackageProductInfo> ShopBeginner => null;

		public List<BundlePackageProductInfo> ShopEquipment => null;

		public List<BundlePackageProductInfo> ShopRune => null;

		public List<BundlePackageProductInfo> ShopCostume => null;

		public List<BundlePackageProductInfo> ShopPet => null;

		public List<BundlePackageProductInfo> ShopSubscription => null;

		public List<BundlePackageProductInfo> ShopGrowth => null;

		public void OnMapValue(string content)
		{
		}

		public List<string> ShowAllSkus()
		{
			return null;
		}

		public List<ShopCrystalProductInfo> GetListShopCrystalProductInfos()
		{
			return null;
		}

		public List<ShopSoulProductInfo> GetListShopSoulProductInfos()
		{
			return null;
		}

		public List<ShopStaminaProductInfo> GetListShopStaminaProductInfos()
		{
			return null;
		}

		public List<ShopSpecialProductInfo> GetListShopSpecialProductInfos()
		{
			return null;
		}

		public List<ShopPackProductInfo> GetListShopPackProductInfos()
		{
			return null;
		}

		public List<ShopTreasureProductInfo> GetListShopTreasureProductInfos()
		{
			return null;
		}

		public List<LevelUpPackageRewardInfo> GetListLevelUpPackageRewardInfos()
		{
			return null;
		}

		public ShopPackProductInfo GetPackageProductInfo(PackageType packageType)
		{
			return null;
		}

		public SubscribePackageRewardInfo GetSubscribePackageRewardInfo()
		{
			return null;
		}

		public List<ItemInfo> GetListSubscribeItemInfos(int index)
		{
			return null;
		}

		public List<BundlePackageProductInfo> GetBundlePackageProductInfosWithCategory(string category)
		{
			return null;
		}

		public List<BundlePackageRewardInfo> GetBundlePackageRewardInfos(int bundleRewardId)
		{
			return null;
		}

		public List<BundlePackageCategoryInfo> GetBundlePackageCategoryInfos()
		{
			return null;
		}

		public List<BundlePackageProductInfo> GetBundlePackageProductInfos()
		{
			return null;
		}

		public bool GetBundlePackageProductInfo(int productId, ref BundlePackageProductInfo productInfo)
		{
			return false;
		}

		public bool FindShopCrystalProductInfoBySku(string sku, ref ShopCrystalProductInfo scpi)
		{
			return false;
		}

		public bool FindShopPackProductInfoBySku(string sku, ref ShopPackProductInfo sppi)
		{
			return false;
		}

		public bool FindBundlePackageProductInfoBySku(string sku, ref BundlePackageProductInfo sppi)
		{
			return false;
		}

		public BundlePackageCategoryInfo GetBundlePackageCategoryInfo(string category)
		{
			return null;
		}

		public List<BundlePackageProductInfo> GetListBundlePackageProductShowOne()
		{
			return null;
		}

		public List<BundlePackageProductInfo> GetRunePackageProductInfos()
		{
			return null;
		}

		public List<BundlePackageProductInfo> GetPetPackageProductInfos()
		{
			return null;
		}

		public List<BundlePackageProductInfo> GetAncientPackageProductInfos()
		{
			return null;
		}

		public List<BundlePackageProductInfo> GetAccessoryPackageProductInfos()
		{
			return null;
		}

		public List<BundlePackageProductInfo> GetShopBlackFridayPackageProductInfos(bool checkData = false)
		{
			return null;
		}

		public UnlockAllCharactersPackageProductInfo GetUnlockAllCharactersPackageProductInfo()
		{
			return null;
		}

		public FlashSaleOreRuneBundleProductInfo GetFlashSaleOreRuneBundleProductInfo()
		{
			return null;
		}

		public int GetCategoryId(string category)
		{
			return 0;
		}

		private void Cache<T>(ref List<T> list, Dictionary<string, T> dict) where T : IProductInfo
		{
		}

		private int ComparerProduct(IProductInfo a, IProductInfo b)
		{
			return 0;
		}

		private int CompareBundle(BundlePackageProductInfo a, BundlePackageProductInfo b)
		{
			return 0;
		}

		private int ComparerLevelUpReward(LevelUpPackageRewardInfo a, LevelUpPackageRewardInfo b)
		{
			return 0;
		}

		private void CacheLevelUpReward()
		{
		}

		private int ComparerRunePackage(BundlePackageProductInfo a, BundlePackageProductInfo b)
		{
			return 0;
		}

		private void CacheSubscribeReward()
		{
		}

		private void CacheBundleRewardInfo()
		{
		}

		private int ComparerBundlePackageReward(BundlePackageRewardInfo a, BundlePackageRewardInfo b)
		{
			return 0;
		}

		private void CacheBundlePackage()
		{
		}

		private void CacheBundlePackageShowOne()
		{
		}

		private void CacheCategory()
		{
		}
	}
}
