using Ssar.Analytics.Metrics.Coreloop;

namespace Ssar.Analytics.Metrics.ShopAndIap
{
	public interface ShopAndIapData : CoreloopData
	{
		float RealMoneySpent();

		string Arena();
	}
}
