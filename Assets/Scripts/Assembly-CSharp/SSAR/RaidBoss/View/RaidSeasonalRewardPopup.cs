using System.Collections.Generic;
using UnityEngine;

namespace Ssar.RaidBoss.View
{
	public class RaidSeasonalRewardPopup : BasePopup
	{
		public RaidPreparationTabView[] TabViews;

		public UIScrollView ScrollView;

		public UIGrid Grid;

		public GameObject btn_close;

		private int seasonCode;

		private List<RaidSeasonalRewardRowView> RewardRowViews;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		private void InitTab()
		{
		}

		private void InitScrollView()
		{
		}

		private void OnChangeTab(RaidDifficulty tabType)
		{
		}

		private void SelectTab(RaidDifficulty tabType)
		{
		}

		public void Show(int seasonCode)
		{
		}
	}
}
