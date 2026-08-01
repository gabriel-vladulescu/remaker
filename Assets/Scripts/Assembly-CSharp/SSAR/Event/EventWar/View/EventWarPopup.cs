using System;
using Ssar.DailyChallenge.View;
using Ssar.Main.View;
using UnityEngine;

namespace Ssar.Event.EventWar.View
{
	public class EventWarPopup : BasePopup
	{
		public UILabel lbToken;

		public UILabel lbTimeRemain;

		public UIGrid rewardContainer;

		public GameObject btnClose;

		public GameObject btn_bloodyTower;

		public MainSceneButtonStore btnShop;

		public ChallengeMapButtonDailyChallenge btnChallenge;

		private EventWarRewardView[] RewardViews;

		private DateTime endTime;

		private ShowPopupNotifyParameter parameter;

		private int death;

		protected override void Awake()
		{
		}

		private void ResetDeath(GameObject go)
		{
		}

		protected override void Start()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		private void Init()
		{
		}

		private void OpenShop(GameObject o)
		{
		}

		private new void Hide(GameObject go)
		{
		}

		internal void Show(ShowPopupNotifyParameter parameter)
		{
		}

		internal void Refresh()
		{
		}

		private void Update()
		{
		}

		private void UpdateData()
		{
		}

		private void UpdateToken()
		{
		}

		private void UpdateRewards()
		{
		}

		private void UpdateTime()
		{
		}

		private void UpdateTimeDisplay()
		{
		}
	}
}
