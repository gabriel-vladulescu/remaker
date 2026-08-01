using UnityEngine;

namespace Ssar.Event.Xmas
{
	public class XmasOnlinePopup : BasePopup
	{
		public UILabel lb_title;

		public UIGrid giftContainer;

		public GameObject btnClose;

		private XmasOnlineGiftView[] giftViews;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		internal void Show()
		{
		}

		internal void Refresh()
		{
		}

		private void Init()
		{
		}
	}
}
