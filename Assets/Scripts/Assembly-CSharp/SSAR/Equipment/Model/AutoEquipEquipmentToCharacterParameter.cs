using System.Collections.Generic;
using Scripts.Config.Stats;
using Scripts.Ssar.Pet;

namespace SSAR.Equipment.Model
{
	public class AutoEquipEquipmentToCharacterParameter : IAutoEquipEquipmentParameter
	{
		private EntityAbilities abilitiesBefore;

		private EntityAbilities abilitiesAfter;

		private List<EquipmentCollectData> EquipmentCollectDatas { get; set; }

		private List<EquipmentCollectData> ancientCollectDatas { get; set; }

		private PetCollectData PetCollectData { get; set; }

		public AutoEquipEquipmentToCharacterParameter(List<EquipmentCollectData> equipmentCollectDatas, List<EquipmentCollectData> ancientCollectDatas, PetCollectData petCollectData)
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

		private void EquipAncients(MainCharacterData mainCharacterData, CharacterEquippedEquipmentData equippedEquipmentData)
		{
		}
	}
}
