using Scripts.Config;
using UnityEngine;

namespace Ssar.Event.DemonInvasion.Popup
{
	public class DemonPassPopup : BasePopup
	{
		public GameObject btn_open;

		public GameObject btn_exit;

		public GameObject model3d;

		protected override void Awake()
		{
		}

		private void OnBuyDemonPass(GameObject go)
		{
		}

		private void GotoDemonRewardPopup(GameObject go)
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		public void Show(DemonPassProductInfo demonPassProductInfo)
		{
		}
	}
}
