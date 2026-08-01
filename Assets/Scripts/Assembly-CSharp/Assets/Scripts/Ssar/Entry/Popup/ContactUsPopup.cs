using UnityEngine;

namespace Assets.Scripts.Ssar.Entry.Popup
{
	public class ContactUsPopup : BasePopup
	{
		public GameObject btn_feedback;

		public GameObject btn_fanPage;

		public GameObject btn_policy;

		public GameObject btn_exit;

		protected override void Awake()
		{
		}

		public void Show()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}
	}
}
