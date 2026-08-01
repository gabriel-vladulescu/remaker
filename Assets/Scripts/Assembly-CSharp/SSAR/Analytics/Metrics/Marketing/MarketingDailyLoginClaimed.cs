namespace Ssar.Analytics.Metrics.Marketing
{
	public class MarketingDailyLoginClaimed : BaseMarketingMetric
	{
		private int day;

		public MarketingDailyLoginClaimed(BaseData baseData, int day)
			: base(null)
		{
		}

		protected override string GetMetricName()
		{
			return null;
		}

		protected override void AddParams(CustomEventData ced)
		{
		}
	}
}
