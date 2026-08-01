using strange.extensions.mediation.impl;

namespace Ssar.DailyChallenge.View
{
	public class DailyChallengePersonalInfoView : strange.extensions.mediation.impl.View
	{
		public UILabel lb_lvText;

		public UILabel lb_lv;

		public UILabel lb_name;

		public UISprite sp_avatar;

		public UISprite sp_division;

		public UILabel lb_attackpower;

		public UILabel lb_difficulty;

		public UILabel lb_battleCount;

		public UILabel lb_roundDefeated;

		public UILabel lb_highestRound;

		public UILabel lb_enemiesKilled;

		public UILabel lb_playedTime;

		public UILabel lb_powerRecommend;

		public UILabel lb_divisionPoint;

		public UITable table;

		private ScenarioDifficulty curDifficulty;

		internal void Show(ScenarioDifficulty difficulty)
		{
		}

		internal void Refresh()
		{
		}
	}
}
