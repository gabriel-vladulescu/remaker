using SSAR.View;
using Scripts.Ssar.Pet;
using UnityEngine;

namespace Assets.Scripts.Ssar.Pet.View
{
	public class PetListPopup : BasePopup
	{
		public PetListTabView[] PetListTabViews;

		public PetListInventoryView InventoryView;

		public GameObject resourcesContainer;

		public GameObject btn_sellAll;

		private PetListTabType curTab;

		private ShortCutFindItem shortCutFindItem;

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		private void SellAll(GameObject go)
		{
		}

		public void Show()
		{
		}

		public void UpdateInventory()
		{
		}

		private void InstantiateResources()
		{
		}

		private void InitTab()
		{
		}

		public void ShowInventoryWithTab(PetListTabType tabType)
		{
		}

		private void ShowTab()
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
