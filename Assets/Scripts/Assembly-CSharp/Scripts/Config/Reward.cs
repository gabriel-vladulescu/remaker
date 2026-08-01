namespace Scripts.Config
{
	public class Reward
	{
		public int rewardId;

		public string itemType;

		public int itemId;

		public int quantity;

		public ItemType ItemTypeValue()
		{
			return default(ItemType);
		}
	}
}
