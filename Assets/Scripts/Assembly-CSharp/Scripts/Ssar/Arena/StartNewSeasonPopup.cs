using System;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Ssar.Arena
{
	public class StartNewSeasonPopup : BasePopup
	{
		public UILabel lb_seasonname;

		public UILabel lb_welcome;

		public UILabel lb_end;

		public UISprite sp_season;

		public UISprite sp_seasonBg;

		public UISprite sp_icon;

		public UISprite sp_division;

		public UILabel lb_inIcon;

		public GameObject wgSeason;

		public GameObject wgTier;

		public GameObject btn_close;

		public GameObject btn_start;

		public GameObject fxContainer;

		public Color32 colorDefaut;

		private GameObject fxRankUp;

		private ShowStartNewSeasonParameter parameter;

		private List<Action> actionList;

		private int index;

		protected override void Awake()
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

		public void Show(ShowStartNewSeasonParameter parameter)
		{
		}

		public void ClaimRewardFinish()
		{
		}

		private void Next(GameObject o)
		{
		}

		private void NextAction()
		{
		}

		private void OldSeason()
		{
		}

		private void OldRank()
		{
		}

		private void ClaimReward()
		{
		}

		private void NewSeason(bool hasPrevious)
		{
		}

		private void NewRank()
		{
		}

		private void ShowIcon(ArenaTier tier, ArenaDivision division, int rank)
		{
		}

		private void ResetTextEnd()
		{
		}

		private string StartSeasonTextFormat()
		{
			return null;
		}

		private string EndSeasonFormat()
		{
			return null;
		}

		private string OldSeasonName()
		{
			return null;
		}

		private string NewSeasonName()
		{
			return null;
		}

		private int CurrentSeasonalCode()
		{
			return 0;
		}

		private void Update()
		{
		}

		private void PlayFx(GameObject fx)
		{
		}
	}
}
