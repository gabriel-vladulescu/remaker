using Scripts.Config.Stats;
using Ssar.Analytics.Metrics.Ancient;

namespace Ssar.Analytics.Metrics.PlayerProgressions
{
	public class WinDungeonMode : DurationMetric
	{
		private PlayerProgressionData playerProgressionData;

		private int gainedExp;

		private int gainedSoul;

		private int gainedItemCount;

		private bool isFirstTime;

		private int loseBeforeClear;

		private AncientEquipmentMetric ancient1;

		private AncientEquipmentMetric ancient2;

		private EntityAbilities entity;

		public int GainedExp
		{
			set
			{
			}
		}

		public int GainedSoul
		{
			set
			{
			}
		}

		public bool IsFirstTime
		{
			set
			{
			}
		}

		public int LoseBeforeClear
		{
			set
			{
			}
		}

		public WinDungeonMode(PlayerProgressionData playerProgressionData)
		{
		}

		public void SetAncient(AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2)
		{
		}

		public void SetEntity(EntityAbilities entityAbilities)
		{
		}

		public void GainItem(string rarity)
		{
		}

		protected override void OnSend()
		{
		}
	}
}
