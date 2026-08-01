namespace Scripts.Config
{
	public class BundlePackageRewardInfo
	{
		public int bundleRewardId { get; set; }

		public string rewardType { get; set; }

		public int rewardValue { get; set; }

		public int order { get; set; }

		public ItemType GetItemType()
		{
			return default(ItemType);
		}

		public ItemInfo GetItemInfo()
		{
			return null;
		}
	}
}
