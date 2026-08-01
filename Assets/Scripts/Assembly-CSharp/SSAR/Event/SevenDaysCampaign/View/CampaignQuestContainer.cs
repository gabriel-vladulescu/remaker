using System.Collections.Generic;
using Scripts.Config;
using UnityEngine;

namespace Ssar.Event.SevenDaysCampaign.View
{
	public class CampaignQuestContainer : MonoBehaviour
	{
		public UIScrollView scrollView;

		public SimpleWrapContent table;

		private List<CampaignRowView> rowViews;

		internal void Show(int day)
		{
		}

		private int Comparer(CampaignConfig.CampaignQuestItem a, CampaignConfig.CampaignQuestItem b)
		{
			return 0;
		}

		private int GetCompareValue(CampaignConfig.CampaignQuestItem questItem)
		{
			return 0;
		}
	}
}
