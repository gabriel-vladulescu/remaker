using System;
using Ssar.Craft.Enum;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace Ssar.Craft.View
{
	public class CraftingPopupTabView : strange.extensions.mediation.impl.View
	{
		public UIToggle toggle;

		public GameObject wg_active;

		public UILabel lb_tab;

		public CraftingTabType tabType;

		private Action<CraftingTabType> onSelect;

		protected override void Awake()
		{
		}

		internal void Init(CraftingTabType tabType, Action<CraftingTabType> onSelect)
		{
		}

		internal void OnChangeTab(CraftingTabType tabType)
		{
		}

		private void Select(GameObject go)
		{
		}

		private void onChange()
		{
		}
	}
}
