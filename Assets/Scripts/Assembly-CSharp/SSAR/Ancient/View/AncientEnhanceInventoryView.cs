using System.Collections.Generic;
using Assets.Scripts.Ssar.Equipment.Command;
using SSAR.Equipment.View;
using UnityEngine;

namespace Ssar.Ancient.View
{
	public class AncientEnhanceInventoryView : AbstractInventoryView
	{
		public UILabel lb_slotcount;

		public GameObject btn_buyslot;

		protected override void Awake()
		{
		}

		protected override void OnShowInventory(List<ICollectData> collectData, ShowInventoryParameter parameter)
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

		internal void UpdateSlotCount()
		{
		}

		private void BuySlot(GameObject o)
		{
		}
	}
}
