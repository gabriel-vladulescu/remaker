using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic.CostumeTestLevel;
using SSAR.Equipment.Enum;
using SSAR.Shop.View;
using Scripts.Ssar.Pet;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class TestPackageEquipment : MonoBehaviour
	{
		private BundlePackageOneProductEquipmentContainer container;

		private MainCharacterData mainCharacterData;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void TestPackageScene()
		{
		}

		private CosmeticTestData GetCosmeticTestData(Dictionary<EquipmentType, OneProductEquipmentData> cosmetic, PetCollectData petData)
		{
			return null;
		}

		private CharacterVisualInfo GetCharacterVisualInfo(EquipmentConfigId equipmentConfigId)
		{
			return null;
		}

		private CharacterVisualInfo GetDefaultVisualInfo(EquipmentType equipmentType)
		{
			return null;
		}
	}
}
