using System;
using System.Collections.Generic;
using Scripts.Config;
using Ssar.Event.DemonInvasion.View;
using UnityEngine;

namespace Ssar.Event.DemonInvasion.Popup
{
	public class DemonInvasionMainPopup : BasePopup
	{
		public GameObject btn_shop;

		public GameObject btn_start;

		public GameObject btn_reward;

		public GameObject container;

		public GameObject btn_event_ended;

		public GameObject objDiableEntries;

		public GameObject objEntries;

		public UILabel lb_crystalRequire;

		public UILabel lb_entries;

		public UILabel lb_time;

		public DemonInvasionChallengesRewardsView view;

		[Header("Info user")]
		public UISprite sp_avatar;

		public UILabel lb_nameDisplay;

		public UILabel lb_level;

		public UILabel lb_power;

		[Header("Info event")]
		public UILabel lb_highestRank;

		public UILabel lb_timePlayer;

		public UILabel lb_enemiesSkill;

		public UILabel lb_token;

		private List<DemonInvasionChallengesRewardsView> rewardsView;

		private DailyChallengeConfig.Dungeon dungeon;

		private ScenarioDifficulty curDifficulty;

		private ShowPopupNotifyParameter parameter;

		private readonly ScenarioDifficulty curDiff;

		private DateTime endTime;

		protected override void Awake()
		{
		}

		private void InitResources()
		{
		}

		private void OpenShop(GameObject go)
		{
		}

		private void OpenReward(GameObject go)
		{
		}

		private void OpenBattle(GameObject go)
		{
		}

		public void Show(ShowPopupNotifyParameter parameter)
		{
		}

		public void Refresh()
		{
		}

		private void Update()
		{
		}

		private void UpdateTime()
		{
		}

		private void UpdateTimeDisplay()
		{
		}

		private void ShowEntry()
		{
		}

		private void ShowInfoUser()
		{
		}

		private void ShowInfoEvent()
		{
		}

		private string ConvertFromSecondsToHours(int s)
		{
			return null;
		}

		protected override bool EnableBack()
		{
			return false;
		}
	}
}
