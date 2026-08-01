using System.Collections.Generic;
using Assets.Scripts.Ssar.Shop.Model;
using Assets.Scripts.Utils;
using SSAR.Shop.View;
using Scripts.Config;
using Ssar.Shop.Model;
using UnityEngine;

public static class ShopUtils
{
	public static Currency GetCurrency(string currency)
	{
		return default(Currency);
	}

	public static void RefreshShopVendorItem(ShopVendorData shopVendorData, int timeInSecond, ShopVendorConfig shopVendorConfig, RandomRuneConfig randomRuneConfig, int characterLv, bool countRefreshTime)
	{
	}

	public static List<ShopVendorItemData> GenerateListShopVendorItemDatas(ShopVendorConfig shopVendorConfig, RandomRuneConfig randomRuneConfig, int characterLv, int pickCount = 10)
	{
		return null;
	}

	public static List<ShopBlackFridayItemData> GenerateListShopBlackFridayItemsData(ShopBlackFridayConfig shopBlackFridayConfig)
	{
		return null;
	}

	public static bool HasBoughtOldLevelUpPackage(MainCharacterData mainCharacterData)
	{
		return false;
	}

	public static ISubscribePackageLogic GetSubscribePackageLogic(MainCharacterData mainCharacterData, ConfigManager configManager)
	{
		return null;
	}

	public static ILevelUpPackageLogic GetLevelUpPackageLogic(MainCharacterData mainCharacterData, ConfigManager configManager)
	{
		return null;
	}

	public static void GetPriceLocalize(IProductInfo productInfo, ref string priceSaleOff, ref string priceBase)
	{
	}

	public static void GetPriceLocalize(string sku, double priceConfig, ref double price, ref string currencyCode)
	{
	}

	public static void GetPriceLocalize(string sku, double priceConfig, double sale, ref string priceSaleOff, ref string priceBase)
	{
	}

	public static void GetPriceLocalize(IProductInfo productInfo, ref string priceSaleOff)
	{
	}

	public static ShopConfig GetShopConfig()
	{
		return null;
	}

	public static string GetRewardLocalize(ConfigManager configManager, ItemInfo itemInfos)
	{
		return null;
	}

	public static string GetRewardLocalize(ConfigManager configManager, List<ItemInfo> itemInfos)
	{
		return null;
	}

	public static T MapClassValue<T>(GameObject item) where T : BasePackView
	{
		return null;
	}

	public static bool IsUseOldSubscribePackage(MainCharacterData mainCharacterData)
	{
		return false;
	}

	public static bool IsUseOldLevelUpPackage(MainCharacterData mainCharacterData, ConfigManager configManager)
	{
		return false;
	}

	public static string ConvertDayToString(int day)
	{
		return null;
	}

	public static bool IsCanShowNewLevelUpPackage(MainCharacterData mainCharacterData)
	{
		return false;
	}

	public static bool CanClaimRewardAtLevel(LevelUpPackageBoughtData levelUpPackageBoughtData, int characterLevel, int level)
	{
		return false;
	}

	public static bool HasClaimedRewardAtLevel(LevelUpPackageBoughtData levelUpPackageBoughtData, int level)
	{
		return false;
	}

	public static bool GetLastestLevelUpPackageBought(MainCharacterData mainCharacterData, ref NewLevelUpPackageBoughtData boughtData)
	{
		return false;
	}

	public static bool HasBoughtNewLevelUpPackageWithProductId(MainCharacterData mainCharacterData, int productId)
	{
		return false;
	}

	public static int GetTimeResetShopVendorInSecond(MainCharacterData mainCharacterData, ConfigManager configManager)
	{
		return 0;
	}

	private static int IsContains(List<ItemInfo> itemInfos, ItemInfo item)
	{
		return 0;
	}

	private static Card ConvertToCard(ShopVendorProductInfo shopVendorProductInfo)
	{
		return null;
	}

	private static ShopVendorItemData ConvertToShopVendorItemData(ShopVendorProductInfo productInfo, RandomRuneConfig randomRuneConfig)
	{
		return null;
	}

	private static EquipmentConfigId GenerateEquipment(ShopVendorProductInfo productInfo)
	{
		return null;
	}

	public static int GetDoubleExpBuffTimeRemaining(int timePurchase, int duration)
	{
		return 0;
	}

	public static int GetDoubleExpBuffTimeRemaining(MainCharacterData mainCharacterData)
	{
		return 0;
	}

	public static bool IsFreeSubscribePackage(NewSubscribePackageProductInfo productInfo)
	{
		return false;
	}

	private static int GetLastTimeShowSubcribePackagePopup()
	{
		return 0;
	}

	public static void SaveCurrentTimeShowSubcribePackagePopup()
	{
	}

	public static bool TodayHasShowSubcribePackagePopup()
	{
		return false;
	}

	public static bool IsCardShopUnlocked(bool showTooltip = false)
	{
		return false;
	}

	public static FirstTimePurchaseProductInfo GetPriorityProduct(List<FirstTimePurchaseProductInfo> productInfos)
	{
		return null;
	}

	public static List<FirstTimePurchaseProductInfo> GetFirstTimePurchaseProductInfos()
	{
		return null;
	}

	public static List<FirstTimePurchaseProductInfo> GetFirstTimePurchaseProductInfos(int level)
	{
		return null;
	}

	private static bool IsValideFirstTimePurchaseProduct(FirstTimePurchaseProductInfo productInfo)
	{
		return false;
	}

	public static bool IsLimitedByTime(BundlePackageProductInfo productInfo)
	{
		return false;
	}

	public static bool IsValidTime(BundlePackageProductInfo productInfo)
	{
		return false;
	}

	public static bool IsAllCharactersPackageUnlocked()
	{
		return false;
	}

	public static int GetEndTimeShowAllCharactersPackage()
	{
		return 0;
	}

	public static int GetNextTimeShowAllCharactersPackage()
	{
		return 0;
	}

	public static bool CheckAndResetShowAllCharactersPackage()
	{
		return false;
	}

	public static bool HasShowAllCharactersPackage()
	{
		return false;
	}

	public static void SetShowAllCharactersPackage()
	{
	}

	public static FlashSaleOreRuneBoughtData GetFlashSaleOreRuneBoughtData()
	{
		return null;
	}

	public static bool IsFlashSaleOreRuneBundleUnlocked()
	{
		return false;
	}

	public static bool CheckNextTimeShowFlashSaleOreRuneBundle()
	{
		return false;
	}

	public static bool CheckEndTimeFlashSaleOreRuneBundle()
	{
		return false;
	}

	public static void ResetFlashSaleOreRuneBundle()
	{
	}

	public static void BoughtOreRuneBundle()
	{
	}

	public static int GetEndTimeShowFlashSaleOreRuneBundle()
	{
		return 0;
	}

	public static int GetNextTimeShowFlashSaleOreRuneBundle()
	{
		return 0;
	}

	public static bool GetReceivedUltimateFlashSaleOreRuneBundle()
	{
		return false;
	}

	public static bool HasShowFlashSaleOreRuneBundle()
	{
		return false;
	}

	public static void SetShowFlashSaleOreRuneBundle()
	{
	}

	public static bool IsShopBlackFridayUnlocked()
	{
		return false;
	}

	public static bool HasShowShopBlackFriday()
	{
		return false;
	}

	public static void SetShowShopBlackFriday()
	{
	}
}
