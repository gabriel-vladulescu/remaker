namespace Ssar.Analytics.Metrics.ShopAndIap
{
	public class ViewItem
	{
		private readonly ShopAndIapData said;

		private readonly string itemCategory;

		private readonly string itemName;

		private readonly string itemId;

		private readonly double money;

		private readonly int viewCount;

		private readonly string currentType;

		public ViewItem(ShopAndIapData said, string itemCategory, string itemName, string itemId, string currentType, double money, int viewCount)
		{
		}

		public void Send()
		{
		}
	}
}
