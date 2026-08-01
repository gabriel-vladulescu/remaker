namespace Ssar.Event.Xmas
{
	public class OnlineRewardInfo
	{
		public int order { get; set; }

		public int timeInMinutes { get; set; }

		public string rewardType { get; set; }

		public int configId { get; set; }

		public int quantity { get; set; }

		public ItemType GetItemType()
		{
			return default(ItemType);
		}

		public ItemInfo ParseToItemInfo()
		{
			return null;
		}

		public static int Comparer(OnlineRewardInfo a, OnlineRewardInfo b)
		{
			return 0;
		}
	}
}
