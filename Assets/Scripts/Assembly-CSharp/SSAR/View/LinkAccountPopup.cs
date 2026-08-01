using System;
using Assets.Scripts.Ssar.Command;
using SSAR.Entry.Model;
using UnityEngine;

namespace SSAR.View
{
	public class LinkAccountPopup : BasePopup
	{
		private class GoogleMethod : AbsMethod
		{
			protected override void LoadData(Action<string, UserData> callBack)
			{
			}
		}

		private class FacebookMethod : AbsMethod
		{
			protected override void LoadData(Action<string, UserData> callBack)
			{
			}
		}

		private class GameCenterMethod : AbsMethod
		{
			protected override void LoadData(Action<string, UserData> callBack)
			{
			}
		}

		private abstract class AbsMethod
		{
			public void Save(Action<bool, string> result)
			{
			}

			public void Load(Action<bool, string> result)
			{
			}

			protected abstract void LoadData(Action<string, UserData> callBack);
		}

		public UILabel lb_title;

		public UILabel lb_linkGG;

		public UILabel lb_linkFb;

		public UILabel lb_linkGC;

		public GameObject btn_linkFb;

		public GameObject btn_linkGG;

		public GameObject btn_linkGC;

		public GameObject btn_close;

		public UITable table;

		private ShowLinkAccountPopupParameter parameter;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		public void Show(ShowLinkAccountPopupParameter parameter)
		{
		}

		public void UpdateData()
		{
		}

		private void LinkToFb(GameObject o)
		{
		}

		private void LinkToGoogle(GameObject o)
		{
		}

		private void LinkToGameCenter(GameObject go)
		{
		}

		private void Invoke(AbsMethod method)
		{
		}

		private void LinkData(UserDataType type, Action<UserData, Action<bool, string>> action, string textSuccess)
		{
		}
	}
}
