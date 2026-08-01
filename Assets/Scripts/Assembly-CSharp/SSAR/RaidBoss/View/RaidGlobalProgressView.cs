using System.Collections.Generic;
using Scripts.Config;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace Ssar.RaidBoss.View
{
	public class RaidGlobalProgressView : strange.extensions.mediation.impl.View
	{
		public UILabel lb_globalKill;

		public UILabel lb_progress;

		public UIProgressBar progressBar;

		public GameObject btn_reward;

		public UIWidget[] milestones;

		public float[] milestoneValues;

		private List<RaidGlobalMilestoneView> milestoneViews;

		private RaidDifficulty curDifficulty;

		private int baseKill;

		private int globalKill;

		private float refreshCooldown;

		private GameObject fx;

		private TweenRotation tweenRotation;

		private TweenPosition tweenPosition;

		private float defaultRefreshTime;

		protected override void Awake()
		{
		}

		private void OpenRewardPopup(GameObject go)
		{
		}

		private void Init()
		{
		}

		internal void Show(RaidDifficulty difficulty)
		{
		}

		internal void UpdateData()
		{
		}

		private void UpdateMilestones()
		{
		}

		private void UpdateProgress(RaidBossConfig.GlobalReward[] checkpoints)
		{
		}

		private void UpdateRewardStatus(RaidBossConfig.GlobalReward[] checkpoints)
		{
		}

		private void InitFx()
		{
		}

		private void EnableTween(bool active)
		{
		}

		private void Update()
		{
		}

		private void SendLoadGlobalProgress()
		{
		}

		private void SendLoadGlobalRewardStatus()
		{
		}
	}
}
