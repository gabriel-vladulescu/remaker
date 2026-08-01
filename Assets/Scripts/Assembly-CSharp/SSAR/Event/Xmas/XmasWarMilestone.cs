namespace Ssar.Event.Xmas
{
	public class XmasWarMilestone
	{
		public int id { get; set; }

		public int point { get; set; }

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

		public static int Comparer(XmasWarMilestone a, XmasWarMilestone b)
		{
			return 0;
		}
	}
}
