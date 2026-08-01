using Ssar.Analytics.Metrics.Ancient;

namespace Ssar.Analytics.Metrics.PlayerProgressions
{
	public class EnterDungeonMode
	{
		private PlayerProgressionData playerProgressionData;

		private bool expBoosterUsed;

		private bool soulBoosterUsed;

		private bool hpPotionUsed;

		private AncientEquipmentMetric ancient1;

		private AncientEquipmentMetric ancient2;

		public EnterDungeonMode(PlayerProgressionData playerProgressionData, bool expBoosterUsed, bool soulBoosterUsed, bool hpPotionUsed, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2)
		{
		}

		public void Send()
		{
		}
	}
}
