using System;
using Assets.Scripts.Ssar.Rune.Enum;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Rune.View
{
	public class RuneInventoryTabView : strange.extensions.mediation.impl.View
	{
		public UIToggle toggle;

		public GameObject wg_active;

		public UILabel lb_tab;

		public RuneInventoryTabType tabType;

		private bool sendSignal;

		private bool isBlockedForUpgrade;

		public Action<RuneInventoryTabType> onSelect;

		protected override void Awake()
		{
		}

		public void Init(RuneInventoryTabType tabType, Action<RuneInventoryTabType> onSelect)
		{
		}

		public void OnChangeTab(RuneInventoryTabType tabType, bool silent = false)
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
