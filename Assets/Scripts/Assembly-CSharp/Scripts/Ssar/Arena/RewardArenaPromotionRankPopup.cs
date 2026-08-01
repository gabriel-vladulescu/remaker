using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Ssar.Arena
{
	public class RewardArenaPromotionRankPopup : BasePopup
	{
		public RewardListTabView[] TabViews;

		public UIScrollView ScrollView;

		public UIGrid Grid;

		public GameObject btn_close;

		private List<RewardListRowView> rewardListRowViews;

		protected override void Awake()
		{
		}

		public void BackToConfirmWithArenaRewardsPopup(GameObject o)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		protected override void ExecuteBack()
		{
		}

		public void Show()
		{
		}

		private void InitTab()
		{
		}

		private void SelectTab(ArenaTier tabType)
		{
		}

		private void InitScrollView()
		{
		}

		private void OnChangeTab(ArenaTier tabType)
		{
		}
	}
}
