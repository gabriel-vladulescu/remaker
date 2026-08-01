using Scripts.Config.Stats;

namespace Ssar.Analytics.Metrics.Coreloop
{
	public class EndPvp : DurationMetric
	{
		private CoreloopData coreloopData;

		private int seasonalCode;

		private int rivalPower;

		private string arena;

		private bool isLose;

		private EntityAbilities entity;

		public EndPvp(int rivalPower)
		{
		}

		public void SendData(CoreloopData coreloopData, int seasonalCode, string arena, bool isLose, EntityAbilities heroEntity)
		{
		}

		protected override void OnSend()
		{
		}
	}
}
