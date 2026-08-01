using UnityEngine;

namespace SSAR.View
{
	public class MainSceneSubPopup : BasePopup
	{
		public enum Mode
		{
			Quest = 0,
			Event = 1
		}

		public UITable table;

		public GameObject mask;

		public UILabel lb_title;

		[Header("Buttons")]
		public GameObject btn_dailyLogin;

		public GameObject btn_dailyQuest;

		public GameObject btn_achievement;

		public GameObject btn_firstAnniversaryQuest;

		public GameObject btn_firstanniversaryLogin;

		public GameObject btn_xmasLogin;

		public GameObject btn_xmasWar;

		public GameObject btn_x2PackageValue;

		public GameObject btn_flashSale;

		public GameObject btn_7dayCampaign;

		public GameObject btn_eventWar;

		public GameObject btn_eventLogin;

		private Mode mode;

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

		public void Show(Mode mode)
		{
		}

		private void DailyLoginPopup(GameObject o)
		{
		}

		private void ShowDailyQuest(GameObject o)
		{
		}

		private void ShowAchievement(GameObject o)
		{
		}

		private void CheckUnlockFeature(GameObject btn, FeatureName featureName, MainScenePopup.Condition condition)
		{
		}

		private void CheckUnlockAchievement()
		{
		}

		private void CheckUnlockFirstAnniversaryQuest()
		{
		}

		private void CheckUnlockFirstAnniversaryLogin()
		{
		}

		private void CheckUnlockXmasLogin()
		{
		}

		private void CheckUnlockXmasWar()
		{
		}

		private void CheckUnlockX2Value()
		{
		}

		private void CheckUnlockFlashSale()
		{
		}

		private void CheckUnlockCampaign()
		{
		}

		private void CheckUnlockEventWar()
		{
		}

		private void CheckUnlockEventLogin()
		{
		}

		private void AnniversaryQuet(GameObject o)
		{
		}

		private void AnniversaryLogin(GameObject o)
		{
		}

		private void XmasLogin(GameObject o)
		{
		}

		private void XmasWar(GameObject o)
		{
		}

		private void X2PackageValue(GameObject o)
		{
		}

		private void FlashSale(GameObject o)
		{
		}

		private void Campaign(GameObject o)
		{
		}

		private void EventWar(GameObject o)
		{
		}

		private void EventLogin(GameObject o)
		{
		}

		private void EventDemonLogin(GameObject go)
		{
		}

		private void EventDemonInvasion(GameObject go)
		{
		}
	}
}
