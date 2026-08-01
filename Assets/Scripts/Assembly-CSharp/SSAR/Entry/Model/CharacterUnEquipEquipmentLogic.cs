using Assets.Scripts.Model;
using SSAR.Equipment.Model;

namespace SSAR.Entry.Model
{
	public class CharacterUnEquipEquipmentLogic : AbsUnEquipItemLogic
	{
		private readonly EquipmentCollectData equipmentCollectData;

		private readonly MainCharacterData mainCharacterData;

		public CharacterUnEquipEquipmentLogic(EquipmentCollectData equipmentCollectData, MainCharacterData mainCharacterData)
		{
		}

		public override void UnEquip()
		{
		}

		public override IItem ItemSelect()
		{
			return null;
		}
	}
}
