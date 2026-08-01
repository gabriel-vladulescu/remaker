using Scripts.Config;
using Ssar.Analytics.Metrics.Coreloop;

namespace Ssar.Analytics.Metrics.ShopAndIap
{
	public class DefaultShopAndIapData : DefaultCoreloopData, ShopAndIapData, CoreloopData
	{
		private readonly MainCharacterData mainCharacterData;

		public DefaultShopAndIapData(BaseData baseData, MainCharacterData mainCharacterData, DungeonConfig dc)
			: base(null, null, null)
		{
		}

		public float RealMoneySpent()
		{
			return 0f;
		}

		public string Arena()
		{
			return null;
		}
	}
}
