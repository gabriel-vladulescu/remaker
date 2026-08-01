using System;

public static class TimeUtils
{
	public static readonly DateTime epoch;

	private static int offsetDays;

	private static int offsetHours;

	private static int offsetMinutes;

	private static int offsetSeconds;

	private static int timeStamp;

	private static int serverTimeInSecond;

	private static float timeGetTimeStamp;

	private const string COLON = ":";

	private const string ZERO_COLON = "00:";

	public static int TimeToNextDayInSecond()
	{
		return 0;
	}

	public static void SetOffset(int days, int hours, int minutes, int seconds)
	{
	}

	public static void SetTimeStamp(int timeStamp)
	{
	}

	public static void UpdateServerTimeInSecond(Action<bool> callback)
	{
	}

	public static bool IsServerThroughNewDay(int fromTimeInSecond)
	{
		return false;
	}

	public static int GetServerTimeInSecond()
	{
		return 0;
	}

	public static string TimeToString(int second, bool keepHour = false)
	{
		return null;
	}

	public static string TimeToStringHmFormat(int second, bool changeToSecondFormat = false)
	{
		return null;
	}

	public static string TimeToStringMsFormat(int second)
	{
		return null;
	}

	public static DateTime CurrentTime()
	{
		return default(DateTime);
	}

	public static int CurrentTimeInSecond()
	{
		return 0;
	}

	public static int CurrentTimeInMilisecond()
	{
		return 0;
	}

	public static DateTime ParseToDateTime(int totalSecondSinceEpoch)
	{
		return default(DateTime);
	}

	public static string TimeToDayFromat(int second)
	{
		return null;
	}

	public static string TimeToDayFromat2(int second)
	{
		return null;
	}

	public static string TimeToHoursFormat(int second)
	{
		return null;
	}

	public static double GetTotalDay(DateTime dateTime)
	{
		return 0.0;
	}

	public static bool IsThroughNewDay(int fromTimeInSecond)
	{
		return false;
	}

	public static bool IsThroughNewDay(int fromTimeInSecond, int currentTime)
	{
		return false;
	}

	private static string NumberToString(int number)
	{
		return null;
	}

	public static bool ParseFromddMMyyyytoDateTime(string text, out DateTime dateTime)
	{
		dateTime = default(DateTime);
		return false;
	}

	private static string ValidateTimeddMMyyyy(string text)
	{
		return null;
	}

	public static string DateTimeToMonthDayLocalize(DateTime dateTime)
	{
		return null;
	}

	private static string Day(int day)
	{
		return null;
	}

	public static DateTime DayOfWeekToDateTime(DateTime currentDate, DayOfWeek dayOfWeek)
	{
		return default(DateTime);
	}

	public static DayOfWeek ToDayOfWeek(string source)
	{
		return default(DayOfWeek);
	}
}
