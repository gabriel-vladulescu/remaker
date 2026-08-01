namespace Ssar.Analytics.Metrics.ShopAndIap
{
	public class BuyPackageBundle : BuyResource
	{
		public BuyPackageBundle(ShopAndIapData shopAndIapData, string goodName, string sku, bool shouldAppendCharacterPostfix)
			: base(null, null, null)
		{
		}

		protected override MetricName GetMetricName()
		{
			return default(MetricName);
		}
	}
}
