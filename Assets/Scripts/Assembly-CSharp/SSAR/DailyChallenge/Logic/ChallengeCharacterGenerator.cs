using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using SSAR.Equipment.Enum;

namespace Ssar.DailyChallenge.Logic
{
	public class ChallengeCharacterGenerator
	{
		private MainCharacterData source;

		public ChallengeCharacterGenerator(MainCharacterData source)
		{
		}

		public MainCharacterData Generate(MainCharacterData target)
		{
			return null;
		}

		private void TransferSkill(MainCharacterData target)
		{
		}

		private void TransferEquipmentVisual(MainCharacterData target)
		{
		}

		private void TransferWeaponVisual(IEquippedEquipmentVisualInfo equipmentVisualInfo, MainCharacterData target)
		{
		}

		private void TransferHelmetVisual(IEquippedEquipmentVisualInfo equipmentVisualInfo, MainCharacterData target)
		{
		}

		private void TransferChestArmorVisual(IEquippedEquipmentVisualInfo equipmentVisualInfo, MainCharacterData target)
		{
		}

		private void TransferWingVisual(IEquippedEquipmentVisualInfo equipmentVisualInfo, MainCharacterData target)
		{
		}

		private void ReplaceVisual(MainCharacterData target, EquipmentType equipmentType, CharacterVisualInfo sourceVisualInfo)
		{
		}

		private EquipmentConfigId GenerateFakeEquipment(EquipmentType equipmentType, StatType statType, Rarity rarity)
		{
			return null;
		}
	}
}
