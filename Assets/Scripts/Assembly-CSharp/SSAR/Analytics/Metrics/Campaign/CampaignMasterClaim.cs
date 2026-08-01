namespace Ssar.Analytics.Metrics.Campaign
{
	public class CampaignMasterClaim : BaseCampaignMetric
	{
		private string visualName;

		public CampaignMasterClaim(BaseData baseData, int questId, string visualName)
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
