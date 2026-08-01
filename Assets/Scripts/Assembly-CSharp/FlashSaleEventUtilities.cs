using System.Collections.Generic;
using Assets.Scripts.Utils;
using Scripts.Config;
using Ssar.Shop.Model;

public static class FlashSaleEventUtilities
{
	public static bool IsEnableEvent(MainCharacterData mainCharacterData)
	{
		return false;
	}

	public static List<FlashSaleItemInfo> GetFlashSaleItemInfos(MainCharacterData mainCharacterData)
	{
		return null;
	}

	public static FlashSaleEventConfig GetConfig()
	{
		return null;
	}

	public static List<int> GenerateRandomListIds(List<FlashSaleItemRateUp> itemRateUps)
	{
		return null;
	}

	public static List<FlashSaleItemRateUp> GenerateItemRateUp(MainCharacterData mainCharacterData)
	{
		return null;
	}

	public static void Refresh(MainCharacterData mainCharacterData)
	{
	}

	private static Card ConvertToCard(FlashSaleItemInfo itemInfo, List<FlashSaleItemRateUp> flashSaleModels)
	{
		return null;
	}
}
