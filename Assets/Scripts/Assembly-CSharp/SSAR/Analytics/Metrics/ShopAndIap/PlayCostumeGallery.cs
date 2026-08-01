namespace Ssar.Analytics.Metrics.ShopAndIap
{
	public class PlayCostumeGallery : PlayCardShop
	{
		public PlayCostumeGallery(ShopAndIapData shopAndIapData)
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
