using Ssar.Analytics.Metrics.Coreloop;

namespace Ssar.Analytics.Metrics.ShopAndIap
{
	public class ShopAndIapCustomEventData : CoreloopCustomEventData
	{
		private readonly ShopAndIapData shopAndIapData;

		public ShopAndIapCustomEventData(ShopAndIapData shopAndIapData)
			: base(null)
		{
		}

		public NewCustomEventData NewCustomEventDataShop()
		{
			return null;
		}
	}
}
