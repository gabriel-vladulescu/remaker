using Assets.Scripts.Ssar.BloodyTower.Enum;
using Scripts.Config;

public static class BloodyTowerUtils
{
	public static ConfigManager GetConfigManager()
	{
		return null;
	}

	public static BloodyTowerConfig GetBloodyTowerConfig()
	{
		return null;
	}

	public static int GetHighestFloorUnlocked(MainCharacterData mainCharacterData)
	{
		return 0;
	}

	public static int GetHighestClearedFloor(MainCharacterData mainCharacterData)
	{
		return 0;
	}

	public static int GetHighestFloorPlayable(ConfigManager configManager)
	{
		return 0;
	}

	public static int GetLevelRequiredToUnlockFloor(int floor, ConfigManager configManager)
	{
		return 0;
	}

	public static void CheckUnLockBloodyTower(BloodyTowerProgressData bloodyTowerProgressData, ConfigManager configManager, int characterLevel)
	{
	}

	public static void CheckUnlockTower()
	{
	}

	public static FloorStatus ParseStarToFloorStatus(int star)
	{
		return default(FloorStatus);
	}

	public static int GetMaxEntryPerDay()
	{
		return 0;
	}

	public static bool IsMaxEntryToday(MainCharacterData mainCharacterData)
	{
		return false;
	}

	public static int GetFreeEntriesPerDay()
	{
		return 0;
	}

	public static bool GetCurrentEntryCost(MainCharacterData mainCharacterData, out int cost)
	{
		cost = default(int);
		return false;
	}

	private static int GetConfigEntryCost(int entryCount)
	{
		return 0;
	}
}
