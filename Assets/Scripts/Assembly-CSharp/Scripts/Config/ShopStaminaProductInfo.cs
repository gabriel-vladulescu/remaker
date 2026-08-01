using CodeStage.AntiCheat.ObscuredTypes;
using SSAR.Shop.Enum;

namespace Scripts.Config
{
	public class ShopStaminaProductInfo : IProductInfo
	{
		private ObscuredInt mStamina;

		private ObscuredInt mBonus;

		private ObscuredDouble mPrice;

		public override int productId { get; set; }

		public override string currency { get; set; }

		public override string icon { get; set; }

		public override int sale { get; set; }

		public override string sku { get; set; }

		public override string name { get; set; }

		public string type { get; set; }

		public int stamina
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

		public StaminaType StaminaType => default(StaminaType);

		public override bool enable { get; set; }
	}
}
