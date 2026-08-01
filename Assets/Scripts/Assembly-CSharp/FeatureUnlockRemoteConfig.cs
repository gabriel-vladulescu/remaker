public class FeatureUnlockRemoteConfig
{
	public int levelRequire;

	public string dungeonRequire;

	public FeatureUnlockRemoteConfig(int levelRequire, string dungeonRequire)
	{
	}

	public FeatureUnlockRemoteConfig(string source)
	{
	}

	public bool IsValidLevelRequire()
	{
		return false;
	}

	public bool IsValidDungeonRequire()
	{
		return false;
	}
}
