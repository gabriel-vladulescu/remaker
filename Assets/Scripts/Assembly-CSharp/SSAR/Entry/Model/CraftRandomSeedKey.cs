using SSAR.Equipment.Enum;

namespace SSAR.Entry.Model
{
	public class CraftRandomSeedKey : IGetRandomSeedKey
	{
		private readonly EquipmentType type;

		private readonly Rarity rarity;

		public CraftRandomSeedKey(EquipmentType type, Rarity rarity)
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
