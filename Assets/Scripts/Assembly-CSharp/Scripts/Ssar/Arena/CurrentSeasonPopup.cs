using UnityEngine;

namespace Scripts.Ssar.Arena
{
	public class CurrentSeasonPopup : BasePopup
	{
		public UILabel lb_division;

		public UILabel lb_content;

		public UISprite sp_icon;

		public GameObject btn_close;

		public GameObject btn_next;

		private RankData rankData;

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

		public void Show(RankData parameter)
		{
		}

		private void Next(GameObject o)
		{
		}
	}
}
