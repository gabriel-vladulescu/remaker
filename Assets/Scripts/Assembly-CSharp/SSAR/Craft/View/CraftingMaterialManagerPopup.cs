using Ssar.Craft.Enum;
using Ssar.Craft.Model;
using UnityEngine;

namespace Ssar.Craft.View
{
	public class CraftingMaterialManagerPopup : BasePopup
	{
		public CraftingMaterialInventoryView InventoryView;

		public CraftingMaterialInventoryTabView[] TabViews;

		public GameObject materialInfoContainer;

		public GameObject resourcesContainer;

		private CraftingMaterialType curTab;

		private CraftingMaterialInfoView materialInfoView;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		private void InitTab()
		{
		}

		private void InstantiateResources()
		{
		}

		private void InitMaterialInfo()
		{
		}

		private void ShowInventoryWithTab(CraftingMaterialType tabType)
		{
		}

		private void UpdateInventory()
		{
		}

		private void ShowTab()
		{
		}

		private void ShowMaterialInfo(CraftingMaterial material)
		{
		}

		internal void Show(CraftingMaterial material)
		{
		}

		internal void Back()
		{
		}
	}
}
