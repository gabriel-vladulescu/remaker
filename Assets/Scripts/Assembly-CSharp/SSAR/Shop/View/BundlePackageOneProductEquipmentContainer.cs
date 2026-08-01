using System.Collections.Generic;
using SSAR.Equipment.Enum;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class BundlePackageOneProductEquipmentContainer : MonoBehaviour
	{
		public GameObject[] equipmentContainer;

		public GameObject[] cosmeticContainer;

		public GameObject[] petsContainer;

		public GameObject petContainer;

		public GameObject modelRoot;

		private GameObject model;

		private GameObject petModel;

		private OneProductEquipmentView[] equipmentViews;

		private OneProductEquipmentView[] cosmeticView;

		private OneProductPetView petView;

		private OneProductPetView[] petViews;

		public Dictionary<EquipmentType, OneProductEquipmentData> equipment;

		public Dictionary<EquipmentType, OneProductEquipmentData> cosmetic;

		public OneProductPetData MyPetPick { get; set; }

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public void Show(List<ItemInfo> itemInfos)
		{
		}

		private void SetActivePetsContainer(bool active)
		{
		}

		private void UpdateModelInfo(GameObject o, bool updateRenderQueue)
		{
		}

		private void Init()
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
	}
}
