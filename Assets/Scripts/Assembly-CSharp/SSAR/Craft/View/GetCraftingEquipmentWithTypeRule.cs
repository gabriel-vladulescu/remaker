using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;

namespace Ssar.Craft.View
{
	public class GetCraftingEquipmentWithTypeRule : IGetCollectDataRule
	{
		private InventoryType inventoryType;

		private readonly ItemLockData itemLockData;

		public GetCraftingEquipmentWithTypeRule(InventoryType inventoryType, ItemLockData itemLockData)
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

		private bool IsLocked(ICollectData collectData)
		{
			return false;
		}
	}
}
