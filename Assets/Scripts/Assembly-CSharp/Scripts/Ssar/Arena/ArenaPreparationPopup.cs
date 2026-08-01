using UnityEngine;

namespace Scripts.Ssar.Arena
{
	public class ArenaPreparationPopup : BasePopup
	{
		public ArenaLeaderboardContainer ArenaLeaderboardContainer;

		public ArenaPersonalInfoView ArenaPersonalInfoView;

		public ArenaPreparationTabView[] TabViews;

		public GameObject btn_start;

		public GameObject resources_container;

		public UILabel lb_staminaRequire;

		public UISprite sp_season;

		public UISprite sp_seasonBg;

		public UILabel lb_seasonName;

		public UILabel lb_refreshLeaderboard;

		public GameObject btn_refresh;

		private ArenaPreparationTabType curTab;

		private float time;

		private float delay;

		protected override void Awake()
		{
		}

		protected override void onEnable()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		public void Show()
		{
		}

		public void OnUpdateLeaderBoard()
		{
		}

		private void OnChangeTab(ArenaPreparationTabType tabType)
		{
		}

		private void SelectTab(ArenaPreparationTabType tabType)
		{
		}

		private void InitTab()
		{
		}

		private void InitResources()
		{
		}

		private void DuelStart(GameObject o)
		{
		}

		private void RefreshLeaderBoard(GameObject o)
		{
		}

		private void Update()
		{
		}
	}
}
