using System;

[Serializable]
public class ShopBlackFridayItemData
{
	public int productId { get; set; }

	public bool soldOut { get; set; }

	public int invest { get; set; }

	public ShopBlackFridayItemData()
	{
	}

	public ShopBlackFridayItemData(int productId)
	{
	}
}
