using System;
using Ssar.Event.SevenDaysCampaign.Command;
using UnityEngine;

namespace Ssar.Event.SevenDaysCampaign.View
{
	public class CampaignPopup : BasePopup
	{
		public UILabel lb_endTime;

		public GameObject btn_close;

		public UITable tabContainer;

		public CampaignQuestContainer questContainer;

		public CampaignMasterQuestPreview masterQuestPreview;

		private CampaignPopupTabView[] tabViews;

		private int currentTab;

		private DateTime endTime;

		private float interval;

		private ShowCampaignParameters parameters;

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

		private void Init()
		{
		}

		private void InitTabs()
		{
		}

		private int GetFirstShowTab()
		{
			return 0;
		}

		private void HidePopup(GameObject o)
		{
		}

		private void ShowQuestTab(int day)
		{
		}

		private void ShowTab()
		{
		}

		private void UpdateTimeDisplay()
		{
		}

		private void Update()
		{
		}

		internal void Show(ShowCampaignParameters parameters)
		{
		}

		internal void Refresh()
		{
		}
	}
}
