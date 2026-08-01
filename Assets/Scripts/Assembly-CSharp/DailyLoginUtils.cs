using Assets.Scripts.Ssar.DailyLogin.Model;

public class DailyLoginUtils
{
	public static bool TodayHasShowPopup()
	{
		return false;
	}

	public static bool TodayCanClaimReward(DailyLoginData dailyLoginData)
	{
		return false;
	}

	public static int GetLastTimeShowDailyLoginPopup()
	{
		return 0;
	}

	public static void SaveCurrentTimeShowDailyLoginPopup()
	{
	}

	public static void SaveDailyLoginData()
	{
	}

	public static int DayFromTimeGenerateNewDailyLoginData(DailyLoginData dailyLoginData)
	{
		return 0;
	}

	public static bool IsValidTimeToClaim(DailyLoginData dailyLoginData)
	{
		return false;
	}

	public static CompactedDailyLoginData CompactData(DailyLoginData dailyLoginData)
	{
		return null;
	}

	public static bool IsClaimable(DailyLoginData dailyLoginData, int day)
	{
		return false;
	}

	public static bool IsTodayReward(DailyLoginData dailyLoginData, int day)
	{
		return false;
	}

	public static int GetCurrentDay(DailyLoginData dailyLoginData)
	{
		return 0;
	}

	public static DailyLoginRewardClaimMode GetClaimMode()
	{
		return default(DailyLoginRewardClaimMode);
	}

	public static bool IsDayByDayMode(DailyLoginData dailyLoginData)
	{
		return false;
	}
}
