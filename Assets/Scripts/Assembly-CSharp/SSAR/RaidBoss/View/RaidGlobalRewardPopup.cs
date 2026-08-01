using System.Collections.Generic;
using Scripts.Config;
using UnityEngine;

namespace Ssar.RaidBoss.View
{
	public class RaidGlobalRewardPopup : BasePopup
	{
		public RaidPreparationTabView[] TabViews;

		public UIScrollView ScrollView;

		public UIGrid Grid;

		public GameObject btn_close;

		private int seasonCode;

		private List<RaidGlobalRewardRowView> RewardRowViews;

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

		private void OnChangeTab(RaidDifficulty difficulty)
		{
		}

		private void SelectTab(RaidDifficulty tabType)
		{
		}

		internal void Show(int seasonCode)
		{
		}

		private RaidBossConfig.GlobalReward[] ReverseRewardOrder(RaidBossConfig.GlobalReward[] globalRewards)
		{
			return null;
		}
	}
}
