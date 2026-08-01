namespace Scripts.Config
{
	public abstract class AbsFacebookRewardInfo
	{
		public string rewardType { get; set; }

		public int value { get; set; }

		public ItemInfo GetItemInfo()
		{
			return null;
		}

		public ItemType GetItemType()
		{
			return default(ItemType);
		}
	}
}
