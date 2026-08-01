using CodeStage.AntiCheat.ObscuredTypes;
using SSAR.Shop.Enum;
using SSAR.Shop.View;

namespace Scripts.Config
{
	public class ShopTreasureProductInfo : IProductInfo
	{
		private ObscuredDouble mPrice;

		public override int productId { get; set; }

		public string title { get; set; }

		public string description { get; set; }

		public string equipmentCategory { get; set; }

		public string subCategory { get; set; }

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

		public int quantity { get; set; }

		public int baseEquipmentId { get; set; }

		public int bonusId { get; set; }

		public string rarityDescription { get; set; }

		public override string sku { get; set; }

		public override string name { get; set; }

		public override string currency { get; set; }

		public override string icon { get; set; }

		public override int sale { get; set; }

		public override bool enable { get; set; }

		public ShopTreastureType GetCategory()
		{
			return default(ShopTreastureType);
		}

		public ShopTreasureSubTabType GetSubCategory()
		{
			return default(ShopTreasureSubTabType);
		}

		public Currency GetCurrency()
		{
			return default(Currency);
		}
	}
}
