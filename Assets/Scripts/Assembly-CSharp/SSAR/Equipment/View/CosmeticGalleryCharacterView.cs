using Assets.Scripts.Ssar.Dungeon.GameModeLogic.CostumeTestLevel;
using SSAR.Equipment.Enum;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class CosmeticGalleryCharacterView : strange.extensions.mediation.impl.View
	{
		public CharacterSimpleStatView CharacterSimpleStatView;

		public GameObject modelRoot;

		public GameObject[] slot;

		public GameObject reset;

		public GameObject test;

		private CosmeticGalleryEquipmentSlotView[] cosmeticSlotViews;

		private GameObject model;

		private MainCharacterData mainCharacterData;

		protected override void Awake()
		{
		}

		private void Reset(GameObject go)
		{
		}

		private void Test(GameObject o)
		{
		}

		protected override void OnDestroy()
		{
		}

		public void Show()
		{
		}

		private void UpdateCosmeticSlot()
		{
		}

		private void InitCosmeticSlot()
		{
		}

		private void OnClickBtnEnableVisual(EquipmentType equipmentType)
		{
		}

		private EquipmentType[] CosmeticTypes()
		{
			return null;
		}

		private void ShowModelPreview()
		{
		}

		private CosmeticTestData GetCosmeticTestData(MainCharacterData mainCharacterData)
		{
			return null;
		}

		private CharacterVisualInfo GetCharacterVisualInfo(EquipmentType equipmentType)
		{
			return null;
		}

		private CharacterVisualInfo GetDefaultVisualInfo(MainCharacterData mainCharacterData, EquipmentType equipmentType)
		{
			return null;
		}
	}
}
