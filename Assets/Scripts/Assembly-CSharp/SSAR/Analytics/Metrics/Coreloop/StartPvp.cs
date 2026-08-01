using Scripts.Config.Stats;
using Ssar.Analytics.Metrics.Ancient;

namespace Ssar.Analytics.Metrics.Coreloop
{
	public class StartPvp
	{
		private readonly CoreloopData coreloopData;

		private readonly int seasonalCode;

		private readonly int rivalPower;

		private readonly int matchTime;

		private readonly string arena;

		private readonly AncientEquipmentMetric ancient1;

		private readonly AncientEquipmentMetric ancient2;

		private readonly EntityAbilities entity;

		public StartPvp(CoreloopData coreloopData, int seasonalCode, string arena, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2, EntityAbilities heroEntity, int rivalPower)
		{
		}

		public void Send()
		{
		}
	}
}
