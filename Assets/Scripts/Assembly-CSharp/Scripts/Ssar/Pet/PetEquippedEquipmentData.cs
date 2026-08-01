using System;
using System.Collections.Generic;
using SSAR.Equipment.Enum;

namespace Scripts.Ssar.Pet
{
	[Serializable]
	public class PetEquippedEquipmentData
	{
		public Dictionary<string, int> equippedEquipmentData;

		public Dictionary<string, bool> visualEnableData;

		public int GetEquipppedEquipmentCollectId(EquipmentType type)
		{
			return 0;
		}

		public void EquipEquipment(EquipmentType type, int collectId)
		{
		}

		public void UnEquipEquipment(EquipmentType type)
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

		public void UnequipAll()
		{
		}
	}
}
