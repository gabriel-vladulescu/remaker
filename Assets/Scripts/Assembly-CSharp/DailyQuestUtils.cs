using System.Collections.Generic;
using Assets.Scripts.Ssar.DataManager;
using Scripts.Config;

public static class DailyQuestUtils
{
	public static int GetDailyQuestRequire(DailyQuestConfig.QuestItem questItem, DailyQuestConfig dailyQuestConfig)
	{
		return 0;
	}

	public static int GetDailyQuestProgress(DailyQuestConfig.QuestItem questitem, DailyQuestConfig dailyQuestConfig, DailyQuestData dailyQuestData)
	{
		return 0;
	}

	public static List<DailyQuestConfig.QuestItem> SortDailyQuest(List<DailyQuestConfig.QuestItem> source)
	{
		return null;
	}

	private static int Comparer(DailyQuestConfig.QuestItem a, DailyQuestConfig.QuestItem b)
	{
		return 0;
	}

	private static int GetOrder(DailyQuestConfig.QuestItem a)
	{
		return 0;
	}

	public static bool IsClaimedDailyQuest(DailyQuestConfig.QuestItem questItem, DailyQuestData dailyQuestData)
	{
		return false;
	}

	public static bool CanClaimDailyQuest(DailyQuestConfig.QuestItem questItem, DailyQuestConfig dailyQuestConfig, DailyQuestData dailyQuestData)
	{
		return false;
	}

	public static bool IsClaimedMasterQuest(DailyQuestData dailyQuestData)
	{
		return false;
	}

	public static bool CanClaimMasterQuest(DailyQuestData dailyQuestData)
	{
		return false;
	}

	public static int GetMasterQuestRequire(DailyQuestData dailyQuestData)
	{
		return 0;
	}

	public static int GetMasterQuestProgress(DailyQuestData dailyQuestData)
	{
		return 0;
	}
}
