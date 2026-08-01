namespace Ssar.Analytics.Metrics.ShopAndIap
{
	public class BuyResource
	{
		private ShopAndIapData shopAndIapData;

		private string goodName;

		private string sku;

		public BuyResource(ShopAndIapData shopAndIapData, string goodName, string sku)
		{
		}

		protected void AlterSkuBy(string newSku)
		{
		}

		public void Send()
		{
		}

		protected virtual MetricName GetMetricName()
		{
			return default(MetricName);
		}
	}
}
