using System;
using Scripts.Config;
using Ssar.Event.EventWar.Model;

namespace Ssar.Event.EventWar
{
	public static class EventWarUtils
	{
		public static EventWarConfig GetConfig()
		{
			return null;
		}

		public static EventWarData GetEventData()
		{
			return null;
		}

		public static EventWarRewardData GetRewardData()
		{
			return null;
		}

		public static int GetCurrentToken()
		{
			return 0;
		}

		public static string GetCurrentEventId()
		{
			return null;
		}

		public static DateTime GetEventStartTime()
		{
			return default(DateTime);
		}

		public static DateTime GetEventEndTime()
		{
			return default(DateTime);
		}

		public static bool IsEventAvailable()
		{
			return false;
		}

		public static bool TodayHasShowPopup()
		{
			return false;
		}

		public static int GetLastTimeShowPopup()
		{
			return 0;
		}

		public static void SaveCurrentTimeShowPopup()
		{
		}

		public static bool HasClaimableReward()
		{
			return false;
		}

		public static bool IsClaimedReward(int id)
		{
			return false;
		}
	}
}
