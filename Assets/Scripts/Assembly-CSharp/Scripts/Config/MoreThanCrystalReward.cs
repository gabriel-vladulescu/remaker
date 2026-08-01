namespace Scripts.Config
{
	public class MoreThanCrystalReward
	{
		public int productId { get; set; }

		public int orderBy { get; set; }

		public string goodName { get; set; }

		public string itemType { get; set; }

		public int itemValue { get; set; }

		public int itemQuantity { get; set; }

		public ItemInfo GetItemInfo()
		{
			return null;
		}

		public ItemType ItemType()
		{
			return default(ItemType);
		}
	}
}
