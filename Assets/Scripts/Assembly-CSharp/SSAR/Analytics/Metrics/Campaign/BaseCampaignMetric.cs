namespace Ssar.Analytics.Metrics.Campaign
{
	public abstract class BaseCampaignMetric
	{
		private BaseData baseData;

		private int questId;

		public BaseCampaignMetric(BaseData baseData, int questId)
		{
		}

		public void Send()
		{
		}

		protected abstract MetricName GetMetricName();

		protected abstract void AddParams(CustomEventData ced);
	}
}
