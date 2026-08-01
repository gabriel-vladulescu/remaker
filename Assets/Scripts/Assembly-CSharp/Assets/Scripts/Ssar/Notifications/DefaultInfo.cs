using System.Collections.Generic;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Notifications
{
	public class DefaultInfo : Notification.Info
	{
		private UserData userData;

		private ConfigManager configManager;

		private long dayInMillis;

		public DefaultInfo(UserData userData, ConfigManager configManager)
		{
		}

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
