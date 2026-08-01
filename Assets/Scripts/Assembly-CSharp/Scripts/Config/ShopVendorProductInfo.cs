using CodeStage.AntiCheat.ObscuredTypes;

namespace Scripts.Config
{
	public class ShopVendorProductInfo : IProductInfo
	{
		private ObscuredInt mValue;

		private ObscuredDouble mPrice;

		public override int productId { get; set; }

		public override double price
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public override string currency { get; set; }

		public override string icon { get; set; }

		public override int sale { get; set; }

		public string itemType { get; set; }

		public int value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int weight { get; set; }

		public override string sku { get; set; }

		public override string name { get; set; }

		public override bool enable { get; set; }

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
