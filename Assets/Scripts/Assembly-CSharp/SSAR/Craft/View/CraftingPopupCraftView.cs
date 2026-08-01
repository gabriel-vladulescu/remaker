using System.Collections.Generic;
using SSAR.Equipment.Enum;
using Scripts.Config;
using Ssar.Craft.Enum;
using Ssar.Craft.Model;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace Ssar.Craft.View
{
	public class CraftingPopupCraftView : strange.extensions.mediation.impl.View
	{
		public CraftableItemInventoryView InventoryView;

		public CraftableItemListView ListView;

		public CraftItemProgressBar ProgressBar;

		public UILabel lbSoulCost;

		public GameObject itemContainer;

		public GameObject infoContainer;

		public GameObject btnCraft;

		public GameObject btnFilter;

		public UIGrid gridMaterials;

		public UITable costTable;

		public UILabel lb_time;

		private CraftingTabType tabType;

		private CraftingInfoContainerView craftingInfoContainerView;

		private CraftingPreviewItemView previewItemView;

		private List<CraftingMaterialView> materialViews;

		private ItemCraftingLogic craftingLogic;

		protected override void Awake()
		{
		}

		private void OnSuccessCraft(bool success)
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void OnEnable()
		{
		}

		private void Craft(GameObject go)
		{
		}

		private void Filter(GameObject go)
		{
		}

		private void Init()
		{
		}

		private void InitCraftInfoContainer()
		{
		}

		private void InitMaterials()
		{
		}

		internal void Show(CraftingTabType tabType, bool clearData)
		{
		}

		internal void Hide()
		{
		}

		internal void UpdateData()
		{
		}

		internal void OnCraftSuccess()
		{
		}

		private void ShowCraftableItems()
		{
		}

		private void ShowMaterials()
		{
		}

		private void ClearMaterials()
		{
		}

		private void ShowSoulCost()
		{
		}

		private List<CraftableItem> GetCraftableList(Rarity[] filterRarities)
		{
			return null;
		}

		private CraftableItem GetCraftableItem(CraftConfig.CraftRecipe recipe, int visualId)
		{
			return null;
		}

		private bool IsEnoughMaterials()
		{
			return false;
		}

		private void AutoCollectCraftingItems()
		{
		}
	}
}
