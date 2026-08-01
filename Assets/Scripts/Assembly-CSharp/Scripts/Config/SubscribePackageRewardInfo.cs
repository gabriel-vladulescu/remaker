namespace Scripts.Config
{
	public class SubscribePackageRewardInfo
	{
		public int productId { get; set; }

		public string rewardType { get; set; }

		public int instantly { get; set; }

		public int perDay { get; set; }

		public int dayCount { get; set; }

		public ItemInfo GetInstantlyReward()
		{
			return null;
		}

		public ItemInfo GetDailyReward()
		{
			return null;
		}
	}
}
