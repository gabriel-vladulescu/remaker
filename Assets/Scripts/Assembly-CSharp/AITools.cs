using System.Collections.Generic;
using System.Reflection;
using Artemis;
using SSAR.BattleSystem.AI;

public static class AITools
{
	private static Dictionary<string, FieldInfo[]> fieldInfos;

	private static Dictionary<string, List<ActionConfig>> actionConfigs;

	private static Dictionary<ActionName, float> defaultPriority;

	public static int spawnCount;

	public static FieldInfo[] GetFieldInfos<T>()
	{
		return null;
	}

	public static List<ActionConfig> GetActionConfigs(string mobType)
	{
		return null;
	}

	public static void ClearCache()
	{
	}

	public static MobType GetMobType(string tags)
	{
		return default(MobType);
	}

	public static float GetDefaultPriority(ActionName action)
	{
		return 0f;
	}

	public static float Round(float value)
	{
		return 0f;
	}

	public static string GetGroupTarget(Entity self, EntityGroupType type)
	{
		return null;
	}

	public static string GetTagName(EntityTagType type)
	{
		return null;
	}

	public static int GetScoreByGroup(Entity self, List<TargetScore> group, string groupName)
	{
		return 0;
	}

	public static TargetScore GetTargetScoreConfigByGroup(Entity self, List<TargetScore> group, string groupName)
	{
		return null;
	}

	public static int GetScoreByTag(List<TargetScore> tag, string tagName)
	{
		return 0;
	}

	public static TargetScore GetTargetScoreConfigByTag(List<TargetScore> tag, string tagName)
	{
		return null;
	}

	public static bool ExcuteLevelIsBigger(AIExcuteLevel curLevel, AIExcuteLevel nextLevel)
	{
		return false;
	}

	public static void ForceStopMove(Entity entity)
	{
	}
}
