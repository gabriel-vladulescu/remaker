namespace Ssar.Analytics.Metrics.ShopAndIap
{
	public class ClickHotDeal : ClickFirstTimePurchase
	{
		public ClickHotDeal(ShopAndIapData shopAndIapData)
			: base(null)
		{
		}

		protected override MetricName MetricNameValue()
		{
			return default(MetricName);
		}
	}
}
