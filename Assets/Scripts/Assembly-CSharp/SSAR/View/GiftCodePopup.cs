using UnityEngine;

namespace SSAR.View
{
	public class GiftCodePopup : BasePopup
	{
		public UIInput input;

		public GameObject btn_close;

		public GameObject btn_receive;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		public void Show()
		{
		}

		private void Receive(GameObject o)
		{
		}
	}
}
