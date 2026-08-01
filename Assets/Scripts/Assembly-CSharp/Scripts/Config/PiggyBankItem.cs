namespace Scripts.Config
{
	public class PiggyBankItem : IProductInfo
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

		public double saveMultiple { get; set; }

		public int init { get; set; }

		public int max { get; set; }

		public int useProductWithPurchasedCount { get; set; }

		public int lv { get; set; }

		public string piggyBankType { get; set; }

		public PiggyBankType GetPiggyBankType()
		{
			return default(PiggyBankType);
		}
	}
}
