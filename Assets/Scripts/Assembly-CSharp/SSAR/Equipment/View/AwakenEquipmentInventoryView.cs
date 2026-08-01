using System.Collections.Generic;
using Assets.Scripts.Ssar.Equipment.Command;
using SSAR.Equipment.Enum;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class AwakenEquipmentInventoryView : AbstractInventoryView
	{
		public UILabel lb_slotcount;

		public GameObject btn_buyslot;

		private CollectType collectType;

		protected override void Awake()
		{
		}

		protected override void OnShowInventory(List<ICollectData> collectData, ShowInventoryParameter parameter)
		{
		}

		public void UpdateSlotCount()
		{
		}

		public override string GetRowPath()
		{
			return null;
		}

		protected override int GetNumChildOfRow()
		{
			return 0;
		}

		private void BuySlot(GameObject o)
		{
		}
	}
}
