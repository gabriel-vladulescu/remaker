using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.Command
{
	public class ShowBannerParameter
	{
		public Action onClickBanner;

		public Action onCloseBannmer;

		public string title;

		public Texture Texture;

		public string eventPeriodText;

		public ShowBannerParameter(string title, Texture texture)
		{
		}

		public ShowBannerParameter ListenOnClickBanner(Action action)
		{
			return null;
		}

		public ShowBannerParameter ListenOnClose(Action action)
		{
			return null;
		}

		public ShowBannerParameter SetTextTime(string eventPeriodText)
		{
			return null;
		}
	}
}
