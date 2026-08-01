using System;
using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Notifications
{
	public abstract class Notification
	{
		public interface Info
		{
			long StaminaIsFullAt();

			long NextDayAt();

			int UnspentSkillPoints();

			long LastTimeNotifyUnspentSkillPoints();

			void SaveLastTimeNotifyUnspentSkillPoints();

			long VendorShopIsRefreshedAt();

			long VodPointIsFullAt();

			void SaveIdCounter(int idCounter);

			long CurrentTimeInMillis();

			void SaveListOfNotificationIds(List<int> ids);

			long DayInMillis();
		}

		public static Notification instance;

		private Info info;

		private List<int> idsOfNotificationInUsed;

		private int idCounter;

		private bool disabled;

		protected Notification(Info info)
		{
		}

		public void SetInfo(Info newInfo)
		{
		}

		public void SetDisable(bool isDisabled)
		{
		}

		public void Start()
		{
		}

		public void End()
		{
		}

		public void SendNotification(long delayInMillis, string title, string message)
		{
		}

		public void SendRepeatingNotification(long delayInMillis, long periodInMillis, string title, string message)
		{
		}

		private void Try(Action action)
		{
		}

		private void ClearNotifications()
		{
		}

		private void ScheduleSendStaminaNotification()
		{
		}

		private void ScheduleSendDailyGiftNotification()
		{
		}

		private void ScheduleSendUnspentSkillPointsNotification()
		{
		}

		private void ScheduleSendVendorShopNotification()
		{
		}

		private void ScheduleSendVideoPointNotification()
		{
		}

		private void ScheduleSendDailyQuestNotification()
		{
		}

		protected abstract void PerformClearNotifications(List<int> idsOfNotificationInUsed);

		protected abstract int PerformSendNotification(long delayInMillis, string title, string message);

		protected abstract int PerformSendRepeatingNotification(long delayInMillis, long periodInMillis, string title, string message);
	}
}
