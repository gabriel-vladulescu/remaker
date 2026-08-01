using System;
using UnityEngine;

namespace Scripts.Ssar.Arena
{
	public class ArenaLeaderboardRowView : MonoBehaviour
	{
		public UILabel lb_textLv;

		public UILabel lb_lv;

		public UILabel lb_userName;

		public UILabel lb_divisionPoint;

		public UILabel lb_attack;

		public UISprite sp_bg;

		public UISprite sp_tier;

		public UISprite sp_division;

		public UISprite sp_avatar;

		public UILabel lb_league;

		public UILabel lb_index;

		public GameObject btn_replay;

		public UISprite sp_country;

		private ArenaLeaderboardRowData rowData;

		public Action<GameObject, ArenaLeaderboardRowData> OnClick;

		public Action<GameObject, ArenaLeaderboardRowData> ClickButtonReplay;

		private void Awake()
		{
		}

		public void Show(int index, ArenaLeaderboardRowData data, bool isRecord)
		{
		}

		public void UpdateData(ArenaLeaderboardRowData arenaLeaderboardRowData)
		{
		}

		public void Hide()
		{
		}

		public void UpdateBg(int index)
		{
		}

		public void UpdateTextColor(int index)
		{
		}
	}
}
