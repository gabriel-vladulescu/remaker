using Ssar.Analytics.Metrics.Ancient;

namespace Ssar.Analytics.Metrics.PlayerProgressions
{
	public class EnterTowerMode
	{
		private PlayerProgressionData playerProgressionData;

		private bool expBoosterUsed;

		private bool soulBoosterUsed;

		private bool hpPotionUsed;

		private string towerNode;

		private string towerHighestNode;

		private AncientEquipmentMetric ancient1;

		private AncientEquipmentMetric ancient2;

		public EnterTowerMode(PlayerProgressionData playerProgressionData, bool expBoosterUsed, bool soulBoosterUsed, bool hpPotionUsed, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2, string towerNode, string towerHighestNode)
		{
		}

		public void Send()
		{
		}
	}
}
