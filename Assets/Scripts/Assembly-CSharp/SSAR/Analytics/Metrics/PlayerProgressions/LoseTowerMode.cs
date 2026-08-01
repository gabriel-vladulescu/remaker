using Scripts.Config.Stats;
using Ssar.Analytics.Metrics.Ancient;

namespace Ssar.Analytics.Metrics.PlayerProgressions
{
	public class LoseTowerMode : DurationMetric
	{
		private PlayerProgressionData playerProgressionData;

		private string losingReason;

		private int tryCount;

		private string reason;

		private int hpPotionUsageCount;

		private string towerNode;

		private string towerHighestNode;

		private AncientEquipmentMetric ancient1;

		private AncientEquipmentMetric ancient2;

		private EntityAbilities entity;

		public int TryCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string Reason
		{
			set
			{
			}
		}

		public LoseTowerMode(PlayerProgressionData playerProgressionData, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2, EntityAbilities heroEntity, string losingReason, string towerNode, string towerHighestNode)
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
