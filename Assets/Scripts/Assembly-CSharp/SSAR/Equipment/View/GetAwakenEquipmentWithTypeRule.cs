using System.Collections.Generic;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;

namespace SSAR.Equipment.View
{
	public class GetAwakenEquipmentWithTypeRule : IGetCollectDataRule
	{
		private InventoryType type;

		private readonly ItemLockData _inventoryData;

		private InventoryData inventoryData;

		private EquipmentCollectData main;

		private Dictionary<EquipmentType, List<EquipmentType>> dict;

		public GetAwakenEquipmentWithTypeRule(EquipmentCollectData main, InventoryType type, ItemLockData inventoryData)
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
