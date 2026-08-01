using System.Collections.Generic;
using Firebase.Analytics;

public class SDKManager : Z_Singleton<SDKManager>
{
	private void Awake()
	{
	}

	private void Start()
	{
	}

	public static void PushAFEvent(string eventName)
	{
	}

	public static void PushAFEvent(string eventName, Dictionary<string, string> eventValue)
	{
	}

	public void PushAFEventAchieved(int _level)
	{
	}

	public static void AddTrackingEvent(string log)
	{
	}

	public static void AddTrackingEvent(string log, Parameter[] parameters)
	{
	}

	public void PushCompletedLevelAF(int _level)
	{
	}

	public void PushStartLevelFirebase(int _level)
	{
	}

	public void PushWinLevelFirebase(int _level)
	{
	}

	private int CastDungeonMapToLevel(int _mapId)
	{
		return 0;
	}
}
