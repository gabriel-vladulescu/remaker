namespace Ssar.Analytics.Metrics.ShopAndIap
{
	public class PlayCardShop : DurationMetric
	{
		private ShopAndIapData shopAndIapData;

		public PlayCardShop(ShopAndIapData shopAndIapData)
		{
		}

		protected override void OnSend()
		{
		}

		protected virtual void AddParams(NewCustomEventData nced)
		{
		}

		protected virtual MetricName MetricNameValue()
		{
			return default(MetricName);
		}
	}
}
