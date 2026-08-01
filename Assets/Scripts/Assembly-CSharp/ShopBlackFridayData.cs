using System;
using System.Collections.Generic;

[Serializable]
public class ShopBlackFridayData
{
	public List<ShopBlackFridayItemData> itemsData;

	public List<ShopBlackFridayItemData> packsData;

	public int lastTimeAppearInSeconds { get; set; }

	public int eventId { get; set; }

	public void UpdateListItem(List<ShopBlackFridayItemData> items, int lastTimeAppearInSeconds)
	{
	}

	public void UpdateListPack(List<ShopBlackFridayItemData> packs, int eventId)
	{
	}

	public ShopBlackFridayItemData FindItemData(int productId)
	{
		return null;
	}

	public ShopBlackFridayItemData FindPackData(int productId)
	{
		return null;
	}

	public bool HasBoughtItem(int productId)
	{
		return false;
	}

	public void BoughtItem(int productId)
	{
	}

	public bool HasBoughtPack(int productId)
	{
		return false;
	}

	public void BoughtPack(int productId)
	{
	}
}
