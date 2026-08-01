using System;
using Scripts.Config;
using Ssar.Event.EventLogin.Model;

namespace Ssar.Event.EventLogin
{
	public static class EventLoginUltis
	{
		public static EventLoginConfig GetConfig()
		{
			return null;
		}

		public static EventLoginData GetData()
		{
			return null;
		}

		public static DateTime GetStartTime()
		{
			return default(DateTime);
		}

		public static DateTime GetEndTime()
		{
			return default(DateTime);
		}

		public static bool IsEventAvailable()
		{
			return false;
		}

		public static bool IsClaimedReward(int day)
		{
			return false;
		}

		public static bool IsClaimable(int day)
		{
			return false;
		}

		public static bool IsTodayReward(int day)
		{
			return false;
		}

		public static bool IsValidTimeToClaim()
		{
			return false;
		}

		public static int GetRewardCount()
		{
			return 0;
		}

		public static EventLoginReward[] GetRewards()
		{
			return null;
		}
	}
}
