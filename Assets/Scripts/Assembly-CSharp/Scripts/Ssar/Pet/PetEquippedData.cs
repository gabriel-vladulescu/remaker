using System;
using LitJson;

namespace Scripts.Ssar.Pet
{
	[Serializable]
	public class PetEquippedData
	{
		[JsonInclude]
		private int petCollectId;

		public void EquipPet(int petCollectId)
		{
		}

		public void UnEquipPet()
		{
		}

		public int GetPetCollectId()
		{
			return 0;
		}

		public bool IsEquipped(int collectId)
		{
			return false;
		}
	}
}
