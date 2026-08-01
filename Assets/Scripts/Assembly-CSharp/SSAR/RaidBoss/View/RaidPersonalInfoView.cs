using UnityEngine;
using strange.extensions.mediation.impl;

namespace Ssar.RaidBoss.View
{
	public class RaidPersonalInfoView : strange.extensions.mediation.impl.View
	{
		public UILabel lb_lvText;

		public UILabel lb_lv;

		public UILabel lb_name;

		public UISprite sp_avatar;

		public UISprite sp_division;

		public UILabel lb_attackpower;

		public UILabel lb_difficulty;

		public UILabel lb_battleCount;

		public UILabel lb_bossKill;

		public UILabel lb_playedTime;

		public UILabel lb_powerRecommend;

		public UILabel lb_entryCount;

		public UILabel lb_rewardBonus;

		public UILabel lb_divisionPoint;

		public GameObject entryContainer;

		public UITable table;

		private RaidDifficulty curDifficulty;

		internal void Show(RaidDifficulty difficulty)
		{
		}

		internal void Refresh()
		{
		}

		internal void UpdateRewardBonus()
		{
		}
	}
}
