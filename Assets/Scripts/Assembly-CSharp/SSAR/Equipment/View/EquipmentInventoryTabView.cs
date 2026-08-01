using System;
using SSAR.Equipment.Enum;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class EquipmentInventoryTabView : strange.extensions.mediation.impl.View
	{
		public UIToggle toggle;

		public GameObject wg_active;

		public UILabel lb_tab;

		public InventoryType tabType;

		public Action<InventoryType> onSelect;

		private new void Awake()
		{
		}

		public void Init(InventoryType tabType, Action<InventoryType> onSelect)
		{
		}

		public void OnChangeTab(InventoryType tabType)
		{
		}

		public void onChange()
		{
		}

		private void Select(GameObject o)
		{
		}
	}
}
