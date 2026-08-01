namespace Ssar.Analytics.Metrics.EventWar
{
	public class EventWarStartRound : BaseEventWarMetric
	{
		private ScenarioDifficulty difficulty;

		private int round;

		public EventWarStartRound(BaseData baseData, ScenarioDifficulty difficulty, int round)
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
