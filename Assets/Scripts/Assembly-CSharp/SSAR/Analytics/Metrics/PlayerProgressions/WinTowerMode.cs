using Scripts.Config.Stats;
using Ssar.Analytics.Metrics.Ancient;

namespace Ssar.Analytics.Metrics.PlayerProgressions
{
	public class WinTowerMode : DurationMetric
	{
		private PlayerProgressionData playerProgressionData;

		private int star;

		private bool firstWin;

		private string towerNode;

		private string towerHighestNode;

		private AncientEquipmentMetric ancient1;

		private AncientEquipmentMetric ancient2;

		private EntityAbilities entity;

		public int Star
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IsFirstWin
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public WinTowerMode(PlayerProgressionData playerProgressionData, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2, EntityAbilities heroEntity, string towerNode, string towerHighestNode)
		{
		}

		protected override void OnSend()
		{
		}
	}
}
