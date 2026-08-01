using SSAR.Shop.Enum;

namespace SSAR.Entry.Model
{
	public class ShopTreasureRandomSeedKey : IGetRandomSeedKey
	{
		private readonly ShopTreastureType type;

		private readonly int quantity;

		public ShopTreasureRandomSeedKey(ShopTreastureType type, int quantity)
		{
		}

		public string GetKey()
		{
			return null;
		}

		public int RandomSeedInitBonusValue()
		{
			return 0;
		}
	}
}
