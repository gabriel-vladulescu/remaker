using System.Collections.Generic;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;

namespace Scripts.Ssar.Pet
{
	public class GetAllPetCanSellRule : IGetCollectDataRule
	{
		private readonly List<EquipmentCombinedType> categories;

		private List<Rarity> rarities;

		private ItemLockData lockData;

		private PetEquippedData characterEquippedEquipmentData;

		public GetAllPetCanSellRule(List<EquipmentCombinedType> categories, List<Rarity> rarities)
		{
		}

		public bool IsSuitableConditions(ICollectData collectData)
		{
			return false;
		}
	}
}
