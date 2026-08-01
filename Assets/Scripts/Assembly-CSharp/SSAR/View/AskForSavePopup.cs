using System;
using UnityEngine;

namespace SSAR.View
{
	public class AskForSavePopup : BasePopup
	{
		public UIPlayTween PlayTween;

		public GameObject btn_close;

		public GameObject btn_remindMeLater;

		public GameObject btn_rate5Star;

		public UILabel lb_reward;

		private Action onClose;

		private bool revert;

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

		private void Rate(GameObject go)
		{
		}

		private void Close(GameObject go)
		{
		}

		public void Show(Action action)
		{
		}
	}
}
