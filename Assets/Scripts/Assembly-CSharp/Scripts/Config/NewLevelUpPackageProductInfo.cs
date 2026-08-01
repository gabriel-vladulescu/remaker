namespace Scripts.Config
{
	public class NewLevelUpPackageProductInfo : IProductInfo
	{
		public override int productId { get; set; }

		public override double price { get; set; }

		public override string currency { get; set; }

		public override string icon { get; set; }

		public override int sale { get; set; }

		public override bool enable { get; set; }

		public override string sku { get; set; }

		public override string name { get; set; }

		public string nameOfTableReward { get; set; }

		public string goodName { get; set; }

		public int level { get; set; }

		public void Disable()
		{
		}
	}
}
