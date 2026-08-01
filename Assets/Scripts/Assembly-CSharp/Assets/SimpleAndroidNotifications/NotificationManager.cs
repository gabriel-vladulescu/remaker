using System;
using UnityEngine;

namespace Assets.SimpleAndroidNotifications
{
	public static class NotificationManager
	{
		private const string FullClassName = "com.hippogames.simpleandroidnotifications.Controller";

		private const string MainActivityClassName = "com.unity3d.player.UnityPlayerActivity";

		public static int Send(TimeSpan delay, string title, string message, Color smallIconColor, NotificationIcon smallIcon = NotificationIcon.Bell)
		{
			return 0;
		}

		public static int SendWithAppIcon(TimeSpan delay, string title, string message, Color smallIconColor, NotificationIcon smallIcon = NotificationIcon.Bell)
		{
			return 0;
		}

		public static int SendCustom(NotificationParams notificationParams)
		{
			return 0;
		}

		public static void Cancel(int id)
		{
		}

		public static void CancelAll()
		{
		}

		private static int ColotToInt(Color color)
		{
			return 0;
		}

		private static string GetSmallIconName(NotificationIcon icon)
		{
			return null;
		}
	}
}
