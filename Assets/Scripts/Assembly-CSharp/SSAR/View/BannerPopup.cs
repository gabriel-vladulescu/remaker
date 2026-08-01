using Assets.Scripts.Ssar.Command;
using UnityEngine;

namespace SSAR.View
{
	public class BannerPopup : BasePopup
	{
		public GameObject btn_close;

		public GameObject btn_banner;

		public UITexture banner;

		public UILabel lb_title;

		public UILabel lb_time;

		private ShowBannerParameter parameter;

		protected override void Awake()
		{
		}

		public void Show(ShowBannerParameter parameter)
		{
		}

		private void ClickBanner(GameObject go)
		{
		}

		private void Close(GameObject o)
		{
		}

		protected override void BackPopup(GameObject o)
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}
	}
}
