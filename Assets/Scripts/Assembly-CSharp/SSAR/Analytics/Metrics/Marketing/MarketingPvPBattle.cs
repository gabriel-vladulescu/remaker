namespace Ssar.Analytics.Metrics.Marketing
{
	public class MarketingPvPBattle : BaseMarketingMetric
	{
		private int battleCount;

		public MarketingPvPBattle(BaseData baseData, int battleCount)
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
