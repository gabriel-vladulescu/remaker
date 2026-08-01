using Ssar.RaidBoss;

namespace Ssar.Analytics.Metrics.Coreloop
{
	public class WinRaid : RaidBattleMetric
	{
		private readonly int battleDurationInMinutes;

		public WinRaid(CoreloopData coreloopData, int characterPower, int bossPower, RaidDifficulty difficulty, Mode mode, int seasonalCode, int battleDurationInMinutes)
			: base(null, 0, 0, default(RaidDifficulty), default(Mode), 0)
		{
		}

		protected override MetricName GetMetricName()
		{
			return default(MetricName);
		}

		protected override NewMetricName GetNewMetricName()
		{
			return default(NewMetricName);
		}

		protected override void AddParam(CustomEventData ced)
		{
		}

		protected override void AddParam(NewCustomEventData nced)
		{
		}
	}
}
