namespace Ssar.Analytics.Metrics.ShopAndIap
{
	public class Purchased
	{
		private readonly ShopAndIapData said;

		private readonly string itemCategory;

		private readonly string itemName;

		private readonly string itemId;

		private readonly double price;

		private readonly string currencyType;

		private readonly int purchasedCount;

		private readonly int purchasedItemCount;

		private readonly int itemViewCount;

		public Purchased(ShopAndIapData said, string itemCategory, string itemName, string itemId, string currencyType, double price, int purchasedItemCount, int purchasedCount, int itemViewCount)
		{
		}

		public void Send()
		{
		}
	}
}
