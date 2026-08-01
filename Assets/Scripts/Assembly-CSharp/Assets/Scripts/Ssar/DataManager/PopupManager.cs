using System;
using System.Collections.Generic;
using strange.extensions.signal.impl;

namespace Assets.Scripts.Ssar.DataManager
{
	public class PopupManager
	{
		private Dictionary<Type, strange.extensions.signal.impl.Signal> autoBackData;

		private Dictionary<string, strange.extensions.signal.impl.Signal> backData;

		private Dictionary<Type, string> currentBackData;

		private List<Type> popupIgnoreDisable;

		private Type curPopup;

		private List<Type> fullScreenPopup;

		private List<BasePopup> listPopupShow;

		private Action<BasePopup, bool> onHidePopup;

		private void SetupPopupIgnoreDisable()
		{
		}

		private void SetupBackManager()
		{
		}

		private void SetFullscreenPopup()
		{
		}

		private void AddToBackPrePopupSystem(Type curPopup, Type prePopup, strange.extensions.signal.impl.Signal signal)
		{
		}

		public void ShowPopup(BasePopup basePopup)
		{
		}

		public void DestroyPopup(BasePopup basePopup)
		{
		}

		public void DisablePopup(BasePopup basePopup, bool showAnotherPopup)
		{
		}

		public void BackPopup(BasePopup currentPopup)
		{
		}

		public bool HasPopupShow()
		{
			return false;
		}

		public bool IsShowPopup<T>() where T : BasePopup
		{
			return false;
		}

		public bool IsLastestPopup(BasePopup popup)
		{
			return false;
		}

		public void ListenOnHidePopup(Action<BasePopup, bool> onHidePopup)
		{
		}

		public void UnListenOnHidePopup(Action<BasePopup, bool> onHidePopup)
		{
		}
	}
}
