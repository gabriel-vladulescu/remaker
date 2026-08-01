using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Notifications
{
	public class TestInfo : Notification.Info
	{
		public static TestInfo instance;

		public static DefaultInfo defaultInfoInstance;

		public long staminaFullInNextSeconds;

		public long nextDayInNextSeconds;

		public int unspentSkillPoint;

		public long vendorShopRefreshInNextSeconds;

		public long vodFullInNextSeconds;

		public bool fixedCurrentTime;

		public long currentTimeInSeconds;

		public long dayInMillis;

		public long StaminaIsFullAt()
		{
			return 0L;
		}

		public long NextDayAt()
		{
			return 0L;
		}

		public int UnspentSkillPoints()
		{
			return 0;
		}

		public long LastTimeNotifyUnspentSkillPoints()
		{
			return 0L;
		}

		public void SaveLastTimeNotifyUnspentSkillPoints()
		{
		}

		public long VendorShopIsRefreshedAt()
		{
			return 0L;
		}

		public long VodPointIsFullAt()
		{
			return 0L;
		}

		public void SaveIdCounter(int idCounter)
		{
		}

		public long CurrentTimeInMillis()
		{
			return 0L;
		}

		public void SaveListOfNotificationIds(List<int> ids)
		{
		}

		public long DayInMillis()
		{
			return 0L;
		}
	}
}
