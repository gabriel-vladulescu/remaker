namespace Scripts.Config
{
	public class NewSubscribePackageProductInfo : IProductInfo
	{
		public override int productId { get; set; }

		public override double price { get; set; }

		public override string currency { get; set; }

		public override string icon { get; set; }

		public override int sale { get; set; }

		public override bool enable { get; set; }

		public override string sku { get; set; }

		public override string name { get; set; }

		public bool current { get; set; }

		public string nameOfTableReward { get; set; }

		public int day { get; set; }

		public int maxFreeBought { get; set; }

		public int dailyVideoTicket { get; set; }

		public void Disable()
		{
		}

		public bool HasDailyVideoTicket()
		{
			return false;
		}
	}
}
