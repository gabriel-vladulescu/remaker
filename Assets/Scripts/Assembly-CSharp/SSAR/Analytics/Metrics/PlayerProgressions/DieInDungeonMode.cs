namespace Ssar.Analytics.Metrics.PlayerProgressions
{
	public class DieInDungeonMode : DurationMetric
	{
		private PlayerProgressionData playerProgressionData;

		private string reason;

		private int hpPotionUsageCount;

		public string Reason
		{
			set
			{
			}
		}

		public DieInDungeonMode(PlayerProgressionData playerProgressionData)
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
