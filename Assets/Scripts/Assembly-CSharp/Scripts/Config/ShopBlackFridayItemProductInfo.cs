namespace Scripts.Config
{
	public class ShopBlackFridayItemProductInfo : IProductInfo
	{
		public override int productId { get; set; }

		public override double price { get; set; }

		public override string currency { get; set; }

		public override string icon { get; set; }

		public override int sale { get; set; }

		public override bool enable { get; set; }

		public override string sku { get; set; }

		public override string name { get; set; }

		public string goodName { get; set; }

		public string itemType { get; set; }

		public int itemValue { get; set; }

		public int itemQuantity { get; set; }

		public int[] itemRandomValue { get; set; }

		public ItemInfo GetItemInfo()
		{
			return null;
		}

		public ItemType GetItemType()
		{
			return default(ItemType);
		}

		public Currency GetCurrency()
		{
			return default(Currency);
		}
	}
}
