using System;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace Ssar.Event.SevenDaysCampaign.View
{
	public class CampaignPopupTabView : strange.extensions.mediation.impl.View
	{
		public UIToggle toggle;

		public GameObject wg_active;

		public GameObject wg_deactive;

		public GameObject wg_lock;

		public UILabel[] lb_tab;

		public CampaignPopupTabNotify notify;

		private int tabDay;

		private int currentDay;

		private bool unlocked;

		private Action<int> onSelect;

		protected override void Awake()
		{
		}

		internal void Init(int tabDay, int currentDay, bool unlocked, Action<int> onSelect)
		{
		}

		internal void OnChangeTab(int tabDay)
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
