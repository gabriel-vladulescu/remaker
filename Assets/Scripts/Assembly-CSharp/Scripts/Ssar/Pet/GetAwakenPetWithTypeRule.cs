using SSAR.Equipment.Enum;
using SSAR.Equipment.View;

namespace Scripts.Ssar.Pet
{
	public class GetAwakenPetWithTypeRule : IGetCollectDataRule
	{
		private readonly InventoryType _inventoryType;

		private MainCharacterData mainCharacterData;

		public GetAwakenPetWithTypeRule(InventoryType inventoryType)
		{
		}

		public bool IsSuitableConditions(ICollectData collectData)
		{
			return false;
		}
	}
}
