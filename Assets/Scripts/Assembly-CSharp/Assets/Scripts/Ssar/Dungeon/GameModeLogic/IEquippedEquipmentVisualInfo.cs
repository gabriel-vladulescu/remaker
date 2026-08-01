using Scripts.Ssar.Pet;

namespace Assets.Scripts.Ssar.Dungeon.GameModeLogic
{
	public interface IEquippedEquipmentVisualInfo
	{
		void GetWeaponInfo(MainCharacterData mainCharacterData, ref CharacterVisualInfo weapon, ref CharacterVisualInfo cosmeticWeapon);

		void GetHelmetInfo(MainCharacterData mainCharacterData, ref CharacterVisualInfo helmet, ref CharacterVisualInfo cosmeticHelmet);

		void GetChestArmorInfo(MainCharacterData mainCharacterData, ref CharacterVisualInfo chestArmor, ref CharacterVisualInfo cosmeticChestArmor);

		void GetWingInfo(MainCharacterData mainCharacterData, ref CharacterVisualInfo wing);

		void GetPetCollectData(MainCharacterData mainCharacterData, ref PetCollectData petCollectData);
	}
}
