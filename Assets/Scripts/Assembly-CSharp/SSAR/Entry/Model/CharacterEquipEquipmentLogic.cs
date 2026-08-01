using Assets.Scripts.Model;
using SSAR.Equipment.Model;

namespace SSAR.Entry.Model
{
	public class CharacterEquipEquipmentLogic : AbsEquipItemLogic
	{
		private readonly EquipmentCollectData equipmentCollectData;

		private readonly MainCharacterData mainCharacterData;

		private readonly SlotType slotType;

		public CharacterEquipEquipmentLogic(EquipmentCollectData equipmentCollectData, MainCharacterData mainCharacterData)
		{
		}

		public CharacterEquipEquipmentLogic(EquipmentCollectData equipmentCollectData, MainCharacterData mainCharacterData, SlotType slotType)
		{
		}

		public override void Equip()
		{
		}

		public override IItem ItemSelect()
		{
			return null;
		}
	}
}
