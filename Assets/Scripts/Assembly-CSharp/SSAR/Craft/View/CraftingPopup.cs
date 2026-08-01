using SSAR.Equipment.Enum;
using SSAR.Equipment.View;
using SSAR.View;
using Ssar.Craft.Enum;
using UnityEngine;

namespace Ssar.Craft.View
{
	public class CraftingPopup : BasePopup
	{
		public CraftingPopupTabView[] tabViews;

		public CraftingInventoryView inventoryView;

		public EquipmentInventoryTabView[] inventoryTabView;

		public CraftingPopupCraftView craftView;

		public CraftingPopupSalvageView salvageView;

		public GameObject tab_inventory;

		public GameObject resourcesContainer;

		public GameObject btn_showCraft;

		public GameObject btn_close;

		private CraftingTabType curTab;

		private InventoryType curInventoryTab;

		private ShortCutFindItem shortCutFindItem;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
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

		private void ShowFunctionTabs()
		{
		}

		private void ShowInventoryTabs()
		{
		}

		private void ShowInventoryEquipment(GameObject go)
		{
		}

		private void ShowCraft(GameObject go)
		{
		}

		private void ShowCraftingWithTab(CraftingTabType tabType)
		{
		}

		private void ShowSalvageWithTab(CraftingTabType tabType)
		{
		}

		private void ShowInventoryWithTab(InventoryType tabType)
		{
		}

		public void UpdateInventory()
		{
		}

		private void InitShortCutFindItem()
		{
		}

		private void CheckEnableShortCut()
		{
		}

		private void ClaimInitRewards()
		{
		}

		public void Show(CraftingTabType tabType)
		{
		}

		internal void OnSalvageItemSuccess()
		{
		}

		internal void OnCraftItemSuccess()
		{
		}
	}
}
