namespace Ssar.Analytics.Metrics.EventWar
{
	public abstract class BaseEventWarMetric
	{
		private BaseData baseData;

		public BaseEventWarMetric(BaseData baseData)
		{
		}

		public void Send()
		{
		}

		protected abstract MetricName GetMetricName();

		protected abstract void AddParams(CustomEventData ced);
	}
}
