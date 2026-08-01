using Ssar.DailyChallenge.Model;

namespace Ssar.Analytics.Metrics.EventWar
{
	public class EventWarEndChallenge : BaseEventWarMetric
	{
		private readonly ScenarioDifficulty difficulty;

		private readonly bool isWin;

		private readonly int battleCount;

		private readonly DailyChallengeRecord record;

		public EventWarEndChallenge(BaseData baseData, ScenarioDifficulty difficulty, bool isWin, int battleCount, DailyChallengeRecord record)
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
