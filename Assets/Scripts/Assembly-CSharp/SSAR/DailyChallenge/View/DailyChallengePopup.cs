using Scripts.Config;
using UnityEngine;

namespace Ssar.DailyChallenge.View
{
	public class DailyChallengePopup : BasePopup
	{
		public DailyChallengePersonalInfoView personalInfoView;

		public DailyChallengeEventInfoView eventInfoView;

		public DailyChallengeRewardContainer rewardContainer;

		public DailyChallengeTabView[] tabViews;

		public GameObject resources_container;

		public GameObject btnStart;

		public GameObject btnDisable;

		public GameObject btnOpenEvent;

		public GameObject objEntries;

		public GameObject objCrystalRequire;

		public UILabel lb_entries;

		public UILabel lb_crystalRequire;

		private DailyChallengeConfig.Dungeon dungeon;

		private ScenarioDifficulty curDifficulty;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		private void InitResources()
		{
		}

		private void InitTabs()
		{
		}

		private void SelectTab(ScenarioDifficulty tabType)
		{
		}

		private void OnChangeTab(ScenarioDifficulty difficulty)
		{
		}

		private void OnChangeDifficulty(ScenarioDifficulty difficulty)
		{
		}

		private void StartOffline(GameObject o)
		{
		}

		private void RefreshLeaderBoard(GameObject o)
		{
		}

		private void EventWar(GameObject o)
		{
		}

		private void ShowEntry()
		{
		}

		public void Show()
		{
		}
	}
}
