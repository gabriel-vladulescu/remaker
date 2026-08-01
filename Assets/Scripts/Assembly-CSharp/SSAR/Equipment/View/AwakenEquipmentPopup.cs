using Assets.Scripts.Model;
using SSAR.Equipment.Enum;
using SSAR.View;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class AwakenEquipmentPopup : BasePopup
	{
		public AwakenEquipmentInventoryView inventoryView;

		public EquipmentInventoryTabView[] tabView;

		public AwakenEquipmentStatContainer AwakenEquipmentStatContainer;

		public GameObject btn_close;

		public AwakenMaterialContainer MaterialContainer;

		public GameObject resourcesContainer;

		private InventoryType curTab;

		private IItem main;

		private ShortCutFindItem shortCutFindItem;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		protected override void ExecuteBack()
		{
		}

		private void InstantiateResources()
		{
		}

		private void InitTab()
		{
		}

		private void ShowTab()
		{
		}

		public void Show(IItem equipmentCollectData)
		{
		}

		private void ActiveTab(IItem item)
		{
		}

		public void AwakenSuccess(IItem equipmentCollectData)
		{
		}

		public void UpdateLayout()
		{
		}

		public void Back()
		{
		}

		public void OnRegister()
		{
		}

		public void UpdateInventoryAndCharacterEquipment(bool updateVisual)
		{
		}

		public void ShowInventoryWithTab(InventoryType tabType)
		{
		}

		private void NotifySeenCategory(InventoryType tabType)
		{
		}

		public void UpdateInventory()
		{
		}

		private InventoryType GetTab(IItem equipmentCollectData)
		{
			return default(InventoryType);
		}

		private void InitShortCut()
		{
		}

		private void CheckEnableShortCut()
		{
		}
	}
}
