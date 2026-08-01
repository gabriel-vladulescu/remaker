using Scripts.Config;

public static class FeatureUtils
{
	public static FeatureUnlockConfig GetConfig()
	{
		return null;
	}

	public static bool IsUnlockFeature(FeatureName featureName)
	{
		return false;
	}

	public static bool IsUnlockFeature(FeatureName featureName, UserData userData, ConfigManager configManager)
	{
		return false;
	}

	public static int GetLevelUnlock(FeatureName featureName)
	{
		return 0;
	}

	public static FeatureUnlockMapInfo GetMapUnlock(FeatureName featureName)
	{
		return null;
	}

	public static string GetMapUnlockName(FeatureName featureName)
	{
		return null;
	}

	public static bool IsQuestUnlocked(UserData userData, ConfigManager configManager)
	{
		return false;
	}

	private static FeatureUnlockRemoteConfig GetUnlockRemoteConfig(FeatureName featureName)
	{
		return null;
	}

	private static string GetRemoteConfigKey(FeatureName featureName)
	{
		return null;
	}
}
