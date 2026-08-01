namespace Ssar.Analytics.Metrics.PlayerProgressions
{
	public class LoseDungeonMode : DurationMetric
	{
		private PlayerProgressionData playerProgressionData;

		private int tryCount;

		private string reason;

		private int hpPotionUsageCount;

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
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LoseDungeonMode(PlayerProgressionData playerProgressionData)
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
