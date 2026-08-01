namespace Ssar.Analytics.Metrics.Social
{
	public class RatingMetric : SocialMetric
	{
		private int dungeonId;

		public RatingMetric(MetricName metricName, SocialData socialData, int dungeonId)
			: base(default(MetricName), null)
		{
		}

		protected override void AddSpecificData(CustomEventData ced)
		{
		}

		protected override void AddSpecificData(NewCustomEventData nced)
		{
		}

		protected override void SendData(NewCustomEventData nced)
		{
		}
	}
}
