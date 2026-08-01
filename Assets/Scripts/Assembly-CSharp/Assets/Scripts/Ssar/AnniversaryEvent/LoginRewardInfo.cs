namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	public class LoginRewardInfo
	{
		public int day { get; set; }

		public string rewardType { get; set; }

		public int configId { get; set; }

		public int quantity { get; set; }

		public bool highlight { get; set; }

		public ItemType GetItemType()
		{
			return default(ItemType);
		}

		public ItemInfo ParseToItemInfo()
		{
			return null;
		}

		public static int Comparer(LoginRewardInfo a, LoginRewardInfo b)
		{
			return 0;
		}
	}
}
