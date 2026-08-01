using System.Collections.Generic;
using Assets.Scripts.Ssar.Equipment.Command;
using SSAR.Equipment.Enum;
using SSAR.Equipment.View;
using UnityEngine;

namespace Assets.Scripts.Ssar.Pet.View
{
	public class PetManagerInventoryView : AbstractInventoryView
	{
		public UILabel lb_slotcount;

		public GameObject btn_buyslot;

		public GameObject btn_autoEquip;

		public GameObject btn_unequip;

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

		private void AutoEquip(GameObject o)
		{
		}

		private void Unequip(GameObject o)
		{
		}
	}
}
