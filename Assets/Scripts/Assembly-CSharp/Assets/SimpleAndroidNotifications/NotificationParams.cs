using System;
using UnityEngine;

namespace Assets.SimpleAndroidNotifications
{
	public class NotificationParams
	{
		public int Id;

		public TimeSpan Delay;

		public string Title;

		public string Message;

		public string Ticker;

		public bool Sound;

		public bool Vibrate;

		public bool Light;

		public NotificationIcon SmallIcon;

		public Color SmallIconColor;

		public string LargeIcon;
	}
}
