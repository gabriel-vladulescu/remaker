namespace Ssar.Analytics.Metrics.EventWar
{
	public class EventWarPassRound : BaseEventWarMetric
	{
		private ScenarioDifficulty difficulty;

		private int round;

		public EventWarPassRound(BaseData baseData, ScenarioDifficulty difficulty, int round)
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
