using CodeStage.AntiCheat.ObscuredTypes;

namespace Scripts.Config
{
	public class ShopCrystalProductInfo : IProductInfo, WrapContentData
	{
		private ObscuredInt mCrystal;

		private ObscuredInt mBonus;

		public override string sku { get; set; }

		public override string name { get; set; }

		public override int productId { get; set; }

		public int crystal
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int bonus
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override double price { get; set; }

		public override string currency { get; set; }

		public override string icon { get; set; }

		public override int sale { get; set; }

		public override bool enable { get; set; }
	}
}
