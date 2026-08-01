namespace Scripts.Config
{
	public class ShopPackProductInfo : IProductInfo
	{
		public override string sku { get; set; }

		public override string name { get; set; }

		public override int productId { get; set; }

		public string type { get; set; }

		public override double price { get; set; }

		public override string currency { get; set; }

		public override string icon { get; set; }

		public override bool enable { get; set; }

		public override int sale { get; set; }

		public PackageType GetPackageCode()
		{
			return default(PackageType);
		}
	}
}
