namespace Ssar.Analytics.Metrics.EventWar
{
	public class EventWarTokenIn : BaseEventWarMetric
	{
		private int token;

		private int quantity;

		private RewardReason source;

		public EventWarTokenIn(BaseData baseData, int token, int quantity, RewardReason source)
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
