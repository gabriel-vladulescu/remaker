using Assets.Scripts.Ssar.Dungeon.View;
using SSAR.BattleSystem.System.Arena.Api;
using UnityEngine;

namespace Scripts.Ssar.Arena
{
	public class ArenaPersonalInfoView : MonoBehaviour
	{
		public UILabel lb_lvText;

		public UILabel lb_lv;

		public UILabel lb_name;

		public UILabel lb_myRanking;

		public UILabel lb_participations;

		public UILabel lb_win;

		public UILabel lb_winningStreaks;

		public UILabel lb_divisionPoint;

		public UILabel lb_tierDivision;

		public UISprite sp_avatar;

		public UISprite sp_tier;

		public UISprite sp_division;

		public UILabel lb_attackpower;

		public GameObject[] starContainer;

		private DuelArenaWinStarView[] DuelArenaWinStarViews;

		private void Awake()
		{
		}

		public void Show()
		{
		}

		private void InitStarPrefab()
		{
		}

		private void ShowStar(UserSeasonProgress seasonalData)
		{
		}
	}
}
