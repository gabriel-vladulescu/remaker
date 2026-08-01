namespace Ssar.Analytics.Metrics.Coreloop
{
	public class ClaimRaidSeasonalReward : JoinRaid
	{
		public ClaimRaidSeasonalReward(CoreloopData coreloopData, int seasonalCode)
			: base(null, 0)
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
	}
}
