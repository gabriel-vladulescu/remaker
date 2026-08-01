using System;
using System.Collections.Generic;
using Ssar.RaidBoss.Command;
using Ssar.RaidBoss.Model;
using UnityEngine;

namespace Ssar.RaidBoss.View
{
	public class RaidStartNewSeasonPopup : BasePopup
	{
		public UILabel lb_seasonname;

		public UILabel lb_welcome;

		public UILabel lb_end;

		public UISprite sp_season;

		public UISprite sp_seasonBg;

		public UISprite sp_icon;

		public UILabel lb_inIcon;

		public GameObject wgSeason;

		public GameObject wgTier;

		public GameObject btn_close;

		public GameObject btn_start;

		public GameObject fxContainer;

		public Color32 colorDefaut;

		private GameObject fxRankUp;

		private List<Action> actionList;

		private int index;

		private ShowRaidStartNewSeasonParameter parameter;

		private RaidLeagueRankData currentRank;

		private RaidLeagueRankData previousRank;

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

		public void Show(ShowRaidStartNewSeasonParameter parameter)
		{
		}

		private void Next(GameObject go)
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

		private void NewSeason(bool hasPrevious)
		{
		}

		private void NewRank()
		{
		}

		private string GetStringRank(RaidLeagueRankData rankData)
		{
			return null;
		}

		private void ShowIcon(RaidLeagueRankData rankData)
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

		private void PlayFx(GameObject fx)
		{
		}
	}
}
