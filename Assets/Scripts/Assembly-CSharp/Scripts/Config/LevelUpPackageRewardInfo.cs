namespace Scripts.Config
{
	public class LevelUpPackageRewardInfo
	{
		public int level { get; set; }

		public string rewardType { get; set; }

		public int value { get; set; }

		public ItemType RewardType()
		{
			return default(ItemType);
		}

		public ItemInfo GetReward()
		{
			return null;
		}
	}
}
