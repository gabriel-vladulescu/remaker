using System;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Scripts.Config;

namespace Ssar.Event.Xmas
{
	public static class XmasEventUtilities
	{
		public static XmasEventConfig Config()
		{
			return null;
		}

		public static XmasLoginData GetLoginData()
		{
			return null;
		}

		public static DateTime GetLoginStartTime()
		{
			return default(DateTime);
		}

		public static DateTime GetLoginEndTime()
		{
			return default(DateTime);
		}

		public static TimeSpan GetLoginRemainTime()
		{
			return default(TimeSpan);
		}

		public static bool IsLoginClaimable()
		{
			return false;
		}

		public static bool IsLoginOver()
		{
			return false;
		}

		public static XmasOnlineData GetOnlineData()
		{
			return null;
		}

		public static DateTime GetOnlineStartTime()
		{
			return default(DateTime);
		}

		public static DateTime GetOnlineEndTime()
		{
			return default(DateTime);
		}

		public static TimeSpan GetOnlineRemainTime()
		{
			return default(TimeSpan);
		}

		public static int GetCurrentOnlineDay()
		{
			return 0;
		}

		public static int GetTodayClaimedCount()
		{
			return 0;
		}

		public static bool IsClaimedAllRewardsToday()
		{
			return false;
		}

		public static bool IsOnlineOver()
		{
			return false;
		}

		public static bool IsOnlineValidToday()
		{
			return false;
		}

		public static bool IsOnlineClaimable()
		{
			return false;
		}

		public static XmasWarData GetWarData()
		{
			return null;
		}

		public static DateTime GetWarStartTime()
		{
			return default(DateTime);
		}

		public static DateTime GetWarEndTime()
		{
			return default(DateTime);
		}

		public static TimeSpan GetWarRemainTime()
		{
			return default(TimeSpan);
		}

		public static bool IsWarOver()
		{
			return false;
		}

		public static bool IsWarClaimable()
		{
			return false;
		}

		public static void UpdateWarKillQuest(BattleMode mode, ScenarioDifficulty difficulty = ScenarioDifficulty.NORMAL, int bonusValue = 0)
		{
		}

		public static void UpdateWarWinQuest(BattleMode mode, int bonusValue = 0, ScenarioDifficulty difficulty = ScenarioDifficulty.NORMAL)
		{
		}
	}
}
