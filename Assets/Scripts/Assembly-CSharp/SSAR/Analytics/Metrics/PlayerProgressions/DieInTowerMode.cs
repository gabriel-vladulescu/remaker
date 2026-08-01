using Scripts.Config.Stats;
using Ssar.Analytics.Metrics.Ancient;

namespace Ssar.Analytics.Metrics.PlayerProgressions
{
	public class DieInTowerMode : DurationMetric
	{
		private PlayerProgressionData playerProgressionData;

		private string reason;

		private int hpPotionUsageCount;

		private string towerNode;

		private string towerHighestNode;

		private AncientEquipmentMetric ancient1;

		private AncientEquipmentMetric ancient2;

		private EntityAbilities entity;

		public string Reason
		{
			set
			{
			}
		}

		public DieInTowerMode(PlayerProgressionData playerProgressionData, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2, EntityAbilities heroEntity, string towerNode, string towerHighestNode)
		{
		}

		public void UseHpPotion()
		{
		}

		protected override void OnSend()
		{
		}
	}
}
