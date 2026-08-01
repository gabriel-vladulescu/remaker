using SSAR.Equipment.Enum;

namespace SSAR.Equipment.View
{
	public class GetEquipmentWithTypeRule : IGetCollectDataRule
	{
		private InventoryType type;

		private InventoryData inventoryData;

		private MainCharacterData mainCharacterData;

		public GetEquipmentWithTypeRule(InventoryType type)
		{
		}

		public bool IsSuitableConditions(ICollectData collectData)
		{
			return false;
		}

		private bool IsSameType(ICollectData collectData)
		{
			return false;
		}

		private bool IsInUse(ICollectData collectData)
		{
			return false;
		}
	}
}
