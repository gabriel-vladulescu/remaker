namespace Ssar.Analytics.Metrics.ShopAndIap
{
	public class PlayResourceShop : PlayCardShop
	{
		private readonly ShopAndIapData shopAndIapData;

		public PlayResourceShop(ShopAndIapData shopAndIapData)
			: base(null)
		{
		}

		protected override MetricName MetricNameValue()
		{
			return default(MetricName);
		}

		protected override void AddParams(NewCustomEventData nced)
		{
		}
	}
}
