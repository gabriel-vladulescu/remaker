using System;
using Scripts.Config;
using Ssar.Event.DemonInvasion.Config;
using Ssar.Event.DemonInvasion.Model;

namespace Ssar.Event.DemonInvasion
{
	public static class DemonInvasionUtils
	{
		public static EventDemonInvasionConfig GetConfig()
		{
			return null;
		}

		public static DemonInvasionSignalManager GetSignalManager()
		{
			return null;
		}

		public static DemonInvasionData GetData()
		{
			return null;
		}

		public static DemonInvasionReward GetReward(int id)
		{
			return null;
		}

		public static DemonInvasionReward[] GetRewards()
		{
			return null;
		}

		public static DemonInvasionLoginGift[] GetDailyGifts()
		{
			return null;
		}

		public static DemonInvasionRank[] GetRanks()
		{
			return null;
		}

		public static DemonInvasionLoginGift GetGift(int day)
		{
			return null;
		}

		public static bool GetReceivedReward(int id, bool demon)
		{
			return false;
		}

		public static int GetCurrentToken()
		{
			return 0;
		}

		public static bool GetUnlockDemonPass()
		{
			return false;
		}

		public static bool IsValidTimeToClaim()
		{
			return false;
		}

		public static int GetDayReceivedGift()
		{
			return 0;
		}

		public static string GetCurrentEventId()
		{
			return null;
		}

		public static DateTime GetChallengeStartTime()
		{
			return default(DateTime);
		}

		public static DateTime GetChallengeEndTime()
		{
			return default(DateTime);
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

		public static bool IsChallengeAvailable()
		{
			return false;
		}

		private static bool IsAvailable(DateTime startTime, DateTime endTime)
		{
			return false;
		}
	}
}
