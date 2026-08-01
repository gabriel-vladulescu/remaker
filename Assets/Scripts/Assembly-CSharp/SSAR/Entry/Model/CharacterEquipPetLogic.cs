using Assets.Scripts.Model;
using Scripts.Ssar.Pet;

namespace SSAR.Entry.Model
{
	public class CharacterEquipPetLogic : AbsEquipItemLogic
	{
		private readonly PetCollectData petCollectData;

		private readonly MainCharacterData mainCharacterData;

		public CharacterEquipPetLogic(PetCollectData petCollectData, MainCharacterData mainCharacterData)
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
