using Ssar.Analytics.Metrics.Ancient;
using Ssar.RaidBoss;

namespace Ssar.Analytics.Metrics.Coreloop
{
	public class EnterRaid : RaidBattleMetric
	{
		private string rank;

		private AncientEquipmentMetric ancient1;

		private AncientEquipmentMetric ancient2;

		public EnterRaid(CoreloopData coreloopData, int characterPower, int bossPower, RaidDifficulty difficulty, Mode mode, int seasonalCode, string rank, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2)
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
