using System;
using System.Collections.Generic;

[Serializable]
public class ShopVendorData
{
	public List<ShopVendorItemData> ItemDatas;

	public int lastTimeAppearInSeconds { get; set; }

	public int refreshCount { get; set; }

	public void UpdateListItem(List<ShopVendorItemData> items, int lastTimeAppearInSeconds)
	{
	}

	public ShopVendorItemData FindShopVendorItemData(int productId)
	{
		return null;
	}

	public void ResetRefreshCount()
	{
	}

	public void CountRefresh()
	{
	}
}
