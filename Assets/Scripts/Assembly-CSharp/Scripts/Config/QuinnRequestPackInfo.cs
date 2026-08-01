using CodeStage.AntiCheat.ObscuredTypes;

namespace Scripts.Config
{
	public class QuinnRequestPackInfo : IProductInfo
	{
		private ObscuredDouble mPrice;

		public override int productId { get; set; }

		public string goodName { get; set; }

		public string itemType { get; set; }

		public int itemValue { get; set; }

		public int itemQuantity { get; set; }

		public int buyCount { get; set; }

		public override string currency { get; set; }

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

		public override string sku { get; set; }

		public override string name { get; set; }

		public override string icon { get; set; }

		public override int sale { get; set; }

		public override bool enable { get; set; }

		public ItemInfo GetItemInfo()
		{
			return null;
		}

		public ItemType ItemType()
		{
			return default(ItemType);
		}

		public Currency Currency()
		{
			return default(Currency);
		}
	}
}
