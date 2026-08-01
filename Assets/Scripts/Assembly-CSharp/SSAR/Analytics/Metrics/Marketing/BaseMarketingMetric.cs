namespace Ssar.Analytics.Metrics.Marketing
{
	public abstract class BaseMarketingMetric
	{
		protected BaseData baseData;

		protected BaseMarketingMetric(BaseData baseData)
		{
		}

		public void Send()
		{
		}

		protected abstract string GetMetricName();

		protected abstract void AddParams(CustomEventData ced);
	}
}
