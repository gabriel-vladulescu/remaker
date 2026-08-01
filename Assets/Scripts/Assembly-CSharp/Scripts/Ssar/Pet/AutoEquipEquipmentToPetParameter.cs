using System.Collections.Generic;
using SSAR.Equipment.Model;
using Scripts.Config.Stats;

namespace Scripts.Ssar.Pet
{
	public class AutoEquipEquipmentToPetParameter : IAutoEquipEquipmentParameter
	{
		private EntityAbilities abilitiesBefore;

		private EntityAbilities abilitiesAfter;

		private readonly PetCollectData petCollectData;

		private readonly List<EquipmentCollectData> equipmentCollectDatas;

		public AutoEquipEquipmentToPetParameter(PetCollectData petCollectData, List<EquipmentCollectData> equipmentCollectDatas, MainCharacterData mainCharacterData)
		{
		}

		public EntityAbilities EntityAbilitiesBefore()
		{
			return null;
		}

		public EntityAbilities EntityAbilitiesAfter()
		{
			return null;
		}

		public void Equip()
		{
		}
	}
}
