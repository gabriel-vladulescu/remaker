using Ssar.RaidBoss;

namespace Ssar.Analytics.Metrics.Coreloop
{
	public abstract class RaidBattleMetric
	{
		private CoreloopData coreloopData;

		private int characterPower;

		private int bossPower;

		private RaidDifficulty difficulty;

		private Mode mode;

		private int seasonalCode;

		public RaidBattleMetric(CoreloopData coreloopData, int characterPower, int bossPower, RaidDifficulty difficulty, Mode mode, int seasonalCode)
		{
		}

		public void Send()
		{
		}

		protected abstract MetricName GetMetricName();

		protected abstract NewMetricName GetNewMetricName();

		protected abstract void AddParam(CustomEventData ced);

		protected abstract void AddParam(NewCustomEventData nced);
	}
}
