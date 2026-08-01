using System;

[Serializable]
public class ShopVendorItemData
{
	public ItemInfo ItemInfo { get; set; }

	public int productId { get; set; }

	public bool soldOut { get; set; }

	public int invest { get; set; }

	public ShopVendorItemData()
	{
	}

	public ShopVendorItemData(int productId)
	{
	}

	public ShopVendorItemData(ItemInfo itemInfo, int productId)
	{
	}

	public bool IsValid()
	{
		return false;
	}
}
