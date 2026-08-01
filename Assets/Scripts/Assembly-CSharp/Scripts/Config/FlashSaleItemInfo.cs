namespace Scripts.Config
{
	public class FlashSaleItemInfo : IProductInfo
	{
		public int itemValue;

		public int itemQuantity;

		public double rate;

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

		public ItemInfo GetItemInfo()
		{
			return null;
		}
	}
}
