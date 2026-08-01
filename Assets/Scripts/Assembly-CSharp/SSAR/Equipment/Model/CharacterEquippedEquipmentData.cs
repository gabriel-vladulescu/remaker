using System;
using System.Collections.Generic;
using SSAR.Equipment.Enum;

namespace SSAR.Equipment.Model
{
	[Serializable]
	public class CharacterEquippedEquipmentData
	{
		public Dictionary<string, int> equippedEquipmentData;

		public Dictionary<string, bool> visualEnableData;

		public int GetEquipppedEquipmentCollectId(EquipmentType type, SlotType slotType = SlotType.DEFAULT)
		{
			return 0;
		}

		public void EquipEquipment(EquipmentType type, int collectId, SlotType slotType = SlotType.DEFAULT)
		{
		}

		public void UnEquipEquipment(EquipmentType type, SlotType slotType = SlotType.DEFAULT)
		{
		}

		private void Equip(string key, int collectId)
		{
		}

		private int GetEquipped(string key)
		{
			return 0;
		}

		public bool IsEquippedEquipment(int collectId)
		{
			return false;
		}

		public SlotType GetEquippedEquipmentSlotType(int collectId)
		{
			return default(SlotType);
		}

		public List<int> GetAllEquippedEquipmentOfType(EquipmentType type)
		{
			return null;
		}

		public void SetEnableVisual(EquipmentType equipmentType, bool isEnable)
		{
		}

		public bool IsEnableVisual(EquipmentType equipmentType)
		{
			return false;
		}

		private string ParseToKey(EquipmentType type, SlotType slotType)
		{
			return null;
		}

		private SlotType ParseToSlotType(string key)
		{
			return default(SlotType);
		}
	}
}
