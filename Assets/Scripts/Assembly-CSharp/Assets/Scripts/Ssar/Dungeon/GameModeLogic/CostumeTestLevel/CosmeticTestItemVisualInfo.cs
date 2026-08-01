using Scripts.Ssar.Pet;

namespace Assets.Scripts.Ssar.Dungeon.GameModeLogic.CostumeTestLevel
{
	public class CosmeticTestItemVisualInfo : IEquippedEquipmentVisualInfo
	{
		private readonly CharacterVisualInfo _weapon;

		private readonly CharacterVisualInfo _cosmeticWeapon;

		private readonly CharacterVisualInfo _helmet;

		private readonly CharacterVisualInfo _cosmeticHelmet;

		private readonly CharacterVisualInfo _chestArmor;

		private readonly CharacterVisualInfo _cosmeticChestArmor;

		private readonly CharacterVisualInfo _cosmeticWing;

		private readonly PetCollectData _pet;

		public CosmeticTestItemVisualInfo(CosmeticTestData cosmeticTestData)
		{
		}

		public void GetWeaponInfo(MainCharacterData mainCharacterData, ref CharacterVisualInfo weapon, ref CharacterVisualInfo cosmeticWeapon)
		{
		}

		public void GetHelmetInfo(MainCharacterData mainCharacterData, ref CharacterVisualInfo helmet, ref CharacterVisualInfo cosmeticHelmet)
		{
		}

		public void GetChestArmorInfo(MainCharacterData mainCharacterData, ref CharacterVisualInfo chestArmor, ref CharacterVisualInfo cosmeticChestArmor)
		{
		}

		public void GetWingInfo(MainCharacterData mainCharacterData, ref CharacterVisualInfo wing)
		{
		}

		public void GetPetCollectData(MainCharacterData mainCharacterData, ref PetCollectData petCollectData)
		{
		}
	}
}
