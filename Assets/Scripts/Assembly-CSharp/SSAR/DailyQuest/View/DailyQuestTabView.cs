using System;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace Ssar.DailyQuest.View
{
	public class DailyQuestTabView : strange.extensions.mediation.impl.View
	{
		public UIToggle toggle;

		public GameObject wg_active;

		public UILabel lb_tab;

		public DailyQuestType tabType;

		private bool sendSignal;

		private bool isBlockedForUpgrade;

		public Action<DailyQuestType> onSelect;

		private new void Awake()
		{
		}

		public void Init(DailyQuestType tabType, Action<DailyQuestType> onSelect)
		{
		}

		public void OnChangeTab(DailyQuestType tabType)
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
