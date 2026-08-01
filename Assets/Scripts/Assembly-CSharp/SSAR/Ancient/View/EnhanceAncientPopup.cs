using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using SSAR.View;
using UnityEngine;

namespace Ssar.Ancient.View
{
	public class EnhanceAncientPopup : BasePopup
	{
		public AncientEnhanceInventoryView inventoryView;

		public EquipmentInventoryTabView[] tabView;

		public AncientEnhanceMaterialContainer materialContainer;

		public AncientEnhanceStatContainer statContainer;

		public GameObject btn_close;

		public GameObject resourcesContainer;

		private InventoryType curTab;

		private EquipmentCollectData mainAncient;

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

		private void InitShortCut()
		{
		}

		private void InitTab()
		{
		}

		private void ShowInventoryWithTab(InventoryType tabType)
		{
		}

		private void ShowTab()
		{
		}

		private void NotifySeenCategory(InventoryType tabType)
		{
		}

		private void CheckEnableShortCut()
		{
		}

		internal void Show(EquipmentCollectData equipmentCollectData)
		{
		}

		internal void UpdateInventory()
		{
		}

		internal void EnhanceSuccess(EquipmentCollectData equipmentCollectData)
		{
		}

		internal void Refresh()
		{
		}
	}
}
