namespace Scripts.Config
{
	public abstract class IProductInfo
	{
		private string m_sku;

		public abstract int productId { get; set; }

		public abstract double price { get; set; }

		public abstract string currency { get; set; }

		public abstract string icon { get; set; }

		public abstract int sale { get; set; }

		public abstract bool enable { get; set; }

		public abstract string sku { get; set; }

		public abstract string name { get; set; }

		public string GetFinalSku()
		{
			return null;
		}
	}
}
