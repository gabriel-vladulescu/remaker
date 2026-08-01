using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Notifications
{
	public class DisableNotification : Notification
	{
		public DisableNotification(Info info)
			: base(null)
		{
		}

		protected override void PerformClearNotifications(List<int> idsOfNotificationInUsed)
		{
		}

		protected override int PerformSendNotification(long delayInMillis, string title, string message)
		{
			return 0;
		}

		protected override int PerformSendRepeatingNotification(long delayInMillis, long periodInMillis, string title, string message)
		{
			return 0;
		}
	}
}
