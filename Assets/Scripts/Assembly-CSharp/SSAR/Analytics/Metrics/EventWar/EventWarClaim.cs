namespace Ssar.Analytics.Metrics.EventWar
{
	public class EventWarClaim : BaseEventWarMetric
	{
		private readonly int rewardId;

		private readonly int token;

		public EventWarClaim(BaseData baseData, int rewardId, int token)
			: base(null)
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
