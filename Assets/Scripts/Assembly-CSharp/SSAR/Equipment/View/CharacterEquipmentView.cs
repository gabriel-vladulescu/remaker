using Assets.Scripts.Model;
using Assets.Scripts.Ssar.Pet.View;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class CharacterEquipmentView : strange.extensions.mediation.impl.View
	{
		public CharacterSimpleStatView CharacterSimpleStatView;

		public GameObject modelRoot;

		public GameObject btn_detail;

		public GameObject[] slot;

		public GameObject[] cosmeticSlot;

		public GameObject petSlot;

		public GameObject[] ancientSlots;

		public GameObject wgEquipmentEquipped;

		public GameObject wgCosmeticEquipped;

		public GameObject btn_pet;

		private EquipmentSlotView[] slotViews;

		private CosmeticSlotView[] cosmeticSlotViews;

		private AncientSlotView[] ancientSlotViews;

		private PetSlotView petSlotView;

		private MainCharacterData mainCharacterData;

		private GameObject model;

		protected override void Awake()
		{
		}

		protected new void OnDisable()
		{
		}

		public void Show(MainCharacterData mainCharacterData, bool updateModel)
		{
		}

		public void ChangeTab(InventoryType inventoryType)
		{
		}

		public void UpdateData(MainCharacterData mainCharacter)
		{
		}

		public void OnShowCharacterDetail()
		{
		}

		public void OnEquipEquipmentSuccess(IItem equipmentCollectData)
		{
		}

		public void OnUnequipEquipmentSuccess(IItem equipmentCollectData)
		{
		}

		public void OnEnableVisual(EquipmentType equipmentType)
		{
		}

		public void OnDisableVisual(EquipmentType equipmentType)
		{
		}

		public void OnHideCharacterDetail()
		{
		}

		public void UpdateEquipment(MainCharacterData mainCharacterData)
		{
		}

		public void UpdateCosmetic(MainCharacterData mainCharacterData)
		{
		}

		public void UpdatePet(MainCharacterData mainCharacterData)
		{
		}

		public void UpdateAncient(MainCharacterData mainCharacterData)
		{
		}

		private void InitSlot()
		{
		}

		private void InitPetSlot()
		{
		}

		private void InitCosmeticSlot()
		{
		}

		private void InitAncientSlots()
		{
		}

		private void OnClickSlot(EquipmentCollectData equipmentCollectData, EquipmentType equipmentType)
		{
		}

		private void OnClickCosmeticSlot(EquipmentCollectData equipmentCollectData, EquipmentType equipmentType)
		{
		}

		private void OnClickBtnEnableVisual(EquipmentType equipmentType)
		{
		}

		private EquipmentType[] EquipmentTypes()
		{
			return null;
		}

		private EquipmentType[] CosmeticTypes()
		{
			return null;
		}

		private EquipmentType[] AncientTypes()
		{
			return null;
		}

		private void ShowDetail(GameObject o)
		{
		}

		private void ShowPet(GameObject o)
		{
		}

		private void ShowModelPreview()
		{
		}
	}
}
