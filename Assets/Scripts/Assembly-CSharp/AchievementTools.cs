using System.Collections.Generic;
using Assets.Scripts.Ssar.DataManager;
using Scripts.Config;

public static class AchievementTools
{
	public static int GetAchievementRequire(JsonAchievementConfig.AchievementItem achievementItem, JsonAchievementConfig jsonAchievementConfig)
	{
		return 0;
	}

	public static int GetAchievementProgress(JsonAchievementConfig.AchievementItem achievementItem, JsonAchievementConfig jsonAchievementConfig, AchievementData achievementData)
	{
		return 0;
	}

	public static bool IsUnlockAchievement(JsonAchievementConfig.AchievementItem achievementItem, JsonAchievementConfig config, AchievementData achievementData)
	{
		return false;
	}

	public static bool IsClaimedAchievement(JsonAchievementConfig.AchievementItem achievementItem, JsonAchievementConfig config, AchievementData achievementData)
	{
		return false;
	}

	public static List<JsonAchievementConfig.AchievementItem> SortAchievement(List<JsonAchievementConfig.AchievementItem> source)
	{
		return null;
	}

	public static bool HasAchievementCanClaim(AchievementData achievementData, List<JsonAchievementConfig.AchievementItem> achievementItems)
	{
		return false;
	}

	private static int Comparer(JsonAchievementConfig.AchievementItem a, JsonAchievementConfig.AchievementItem b)
	{
		return 0;
	}

	private static int GetOrder(JsonAchievementConfig.AchievementItem a)
	{
		return 0;
	}
}
