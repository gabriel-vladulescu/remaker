using System.Collections.Generic;
using Ssar.Craft.Model;
using UnityEngine;

namespace Ssar.Craft.View
{
	public class CraftingInfoContainerView : MonoBehaviour
	{
		public delegate void SuccessCraft(bool success);

		public CraftableEquipmentView craftableEquipmentView;

		public CraftableRuneView craftableRuneView;

		public GameObject btn_close;

		[Header("Button Craft")]
		public GameObject btnCraft;

		public UIGrid gridMaterials;

		public UITable costTable;

		public UILabel lbSoulCost;

		public List<CraftingMaterialView> materialViews;

		public ItemCraftingLogic craftingLogic;

		public CraftableItem craftableItem;

		public SuccessCraft onSuccessCraft;

		private void Awake()
		{
		}

		private void Init()
		{
		}

		private void InitMaterials()
		{
		}

		private void Close(GameObject o)
		{
		}

		private void Craft(GameObject go)
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

		private void ShowCraftableItem()
		{
		}

		internal void Show(CraftableItem craftableItem)
		{
		}

		internal void UpdateData()
		{
		}

		internal void Hide()
		{
		}
	}
}
