using Assets.Scripts.Model;
using Scripts.Ssar.Pet;

namespace SSAR.Entry.Model
{
	public class CharacterUnEquipPetLogic : AbsUnEquipItemLogic
	{
		private readonly PetCollectData petCollectData;

		private readonly MainCharacterData mainCharacterData;

		public CharacterUnEquipPetLogic(PetCollectData petCollectData, MainCharacterData mainCharacterData)
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
