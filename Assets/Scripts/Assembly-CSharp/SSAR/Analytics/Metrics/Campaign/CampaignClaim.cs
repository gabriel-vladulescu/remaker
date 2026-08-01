namespace Ssar.Analytics.Metrics.Campaign
{
	public class CampaignClaim : BaseCampaignMetric
	{
		private int mile;

		public CampaignClaim(BaseData baseData, int questId, int mile)
			: base(null, 0)
		{
		}

		protected override MetricName GetMetricName()
		{
			return default(MetricName);
		}

		protected override void AddParams(CustomEventData ced)
		{
		}
	}
}
