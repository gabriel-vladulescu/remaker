namespace Ssar.Analytics.Metrics.Social
{
	public class SocialMetric
	{
		private MetricName metricName;

		private SocialData socialData;

		public SocialMetric(MetricName metricName, SocialData socialData)
		{
		}

		public void Send()
		{
		}

		protected virtual void AddSpecificData(CustomEventData ced)
		{
		}

		protected virtual void AddSpecificData(NewCustomEventData nced)
		{
		}

		protected virtual void SendData(NewCustomEventData nced)
		{
		}
	}
}
