namespace Ssar.Analytics.Metrics.ShopAndIap
{
	public class BeginCheckout
	{
		private readonly ShopAndIapData said;

		private readonly string itemCategory;

		private readonly string itemName;

		private readonly string itemId;

		private readonly double money;

		private readonly string currentType;

		private readonly int itemViewCount;

		public BeginCheckout(ShopAndIapData said, string itemCategory, string itemName, string itemId, string currentType, double money, int itemViewCount)
		{
		}

		public void Send()
		{
		}
	}
}
