namespace Ssar.Analytics.Metrics.EventWar
{
	public class EventWarStartChallenge : BaseEventWarMetric
	{
		private ScenarioDifficulty difficulty;

		private int battleCount;

		public EventWarStartChallenge(BaseData baseData, ScenarioDifficulty difficulty, int battleCount)
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
