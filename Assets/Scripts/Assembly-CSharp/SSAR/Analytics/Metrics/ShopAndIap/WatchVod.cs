namespace Ssar.Analytics.Metrics.ShopAndIap
{
	public class WatchVod
	{
		private ShopAndIapData shopAndIapData;

		private string source;

		public WatchVod(ShopAndIapData shopAndIapData, string source)
		{
		}

		public void Send()
		{
		}

		public void SendNewMetric()
		{
		}

		public virtual NewMetricName GetNewMetricName()
		{
			return default(NewMetricName);
		}
	}
}
