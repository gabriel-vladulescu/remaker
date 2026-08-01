namespace Ssar.Analytics.Metrics.ShopAndIap
{
	public class RewardVod : WatchVod
	{
		public RewardVod(ShopAndIapData shopAndIapData, string source)
			: base(null, null)
		{
		}

		public override NewMetricName GetNewMetricName()
		{
			return default(NewMetricName);
		}
	}
}
