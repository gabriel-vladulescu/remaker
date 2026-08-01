using System;
using Ssar.RaidBoss.Model;
using UnityEngine;

namespace Ssar.RaidBoss.View
{
	public class RaidLeaderboardRowView : MonoBehaviour
	{
		public UILabel lb_textLv;

		public UILabel lb_lv;

		public UILabel lb_userName;

		public UILabel lb_divisionPoint;

		public UILabel lb_attack;

		public UISprite sp_bg;

		public UISprite sp_division;

		public UISprite sp_avatar;

		public UILabel lb_kill;

		public UILabel lb_index;

		public UISprite sp_country;

		public Action<GameObject, RaidLeaderboardRowData> OnClick;

		private RaidLeaderboardRowData rowData;

		private void Awake()
		{
		}

		internal void Show(int index, RaidLeaderboardRowData data)
		{
		}

		internal void Hide()
		{
		}

		private void UpdateData(RaidLeaderboardRowData data)
		{
		}

		private void UpdateBg(int index)
		{
		}
	}
}
