using Assets.Scripts.Model;
using SSAR.Equipment.Enum;
using SSAR.Equipment.View;
using SSAR.View;
using Scripts.Ssar.Pet;
using UnityEngine;

namespace Assets.Scripts.Ssar.Pet.View
{
	public class PetManagerPopup : BasePopup
	{
		public GameObject wg_info;

		public PetManagerInventoryView PetManagerInventoryView;

		public EquipmentInventoryTabView[] tabView;

		public GameObject resourcesContainer;

		private PetInfoContainer petInfoContainer;

		private InventoryType curTab;

		private PetCollectData petCollectData;

		private ShortCutFindItem shortCutFindItem;

		protected override void Awake()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		public void Show(PetCollectData petCollectData)
		{
		}

		public void Reshow()
		{
		}

		public void UpdateData()
		{
		}

		public void OnEquipSuccess(IItem item)
		{
		}

		public void UpdateInventoryView()
		{
		}

		public void OnSell()
		{
		}

		private void ShowTab()
		{
		}

		private void InitTab()
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

		private void InstantiateResources()
		{
		}

		private void InitInfo()
		{
		}

		private void InitShortCutFindItem()
		{
		}

		private void CheckEnableShortCut()
		{
		}
	}
}
