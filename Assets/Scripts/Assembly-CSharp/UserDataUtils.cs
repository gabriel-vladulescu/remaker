using System.Collections.Generic;
using Assets.Scripts.Config.Stats;
using Assets.Scripts.Ssar.DataManager;
using Assets.Scripts.Ssar.Entry;
using SSAR.WorldMap.Model;
using Scripts.Config;
using Ssar.Event.SevenDaysCampaign.Model;

public static class UserDataUtils
{
	public enum CharacterCreationContext
	{
		Demo = 0,
		Free = 1,
		Paid = 2
	}

	public static UserData InitDataTest(int groupId, int subId)
	{
		return null;
	}

	private static WorldMapData GetWorldMapData()
	{
		return null;
	}

	private static InventoryData InitInventoryData()
	{
		return null;
	}

	private static void AddBoostItem(InventoryData inventoryData)
	{
	}

	public static MainCharacterData CreateCharacter(UserData userData, int groupId, int subId, CharacterCreationContext context = CharacterCreationContext.Free)
	{
		return null;
	}

	public static MainCharacterData CreateCharacter(int groupId, int subId, CharacterCreationContext context = CharacterCreationContext.Free)
	{
		return null;
	}

	private static void InitEquipment(MainCharacterData mainCharacterData, CharacterCreationContext context = CharacterCreationContext.Free)
	{
	}

	private static AbsCharacterGenerateEquipmentLogic getCharacter1GenerateEquipmentLogic(MainCharacterData mainCharacterData, ConfigManager configManager)
	{
		return null;
	}

	public static AbsCharacterGenerateEquipmentLogic GetCharacter1GenerateEquipmentLogic(int groupdId, ConfigManager configManager)
	{
		return null;
	}

	private static void InitAchievementData(AchievementData ad, JsonAchievementConfig jac)
	{
	}

	private static void InitCampaignData(CampaignData data, ConfigManager configManager)
	{
	}

	public static int GetCharacterLevel(MainCharacterData mainCharacterData)
	{
		return 0;
	}

	public static int GetCharacterLevel(MainCharacterData mainCharacterData, ConfigManager configManager)
	{
		return 0;
	}

	public static float GetExpProgress(int totalExp, int groupId, int subId, HeroConfig config)
	{
		return 0f;
	}

	public static float GetExpProgress(int totalExp, int groupId, int subId, List<HeroLevelStats> userExps)
	{
		return 0f;
	}

	public static int ExpProgressToExp(float progress, List<HeroLevelStats> userExps)
	{
		return 0;
	}

	public static float GetExpProgress(int totalExp, int groupId, int subId)
	{
		return 0f;
	}

	public static float GetExpProgress(int totalExp, int groupId, int subId, ConfigManager configManager)
	{
		return 0f;
	}

	public static int GetCurrentCharacterLevel()
	{
		return 0;
	}

	public static bool IsMaxLevel(int level, int groupId, int subId, HeroConfig config)
	{
		return false;
	}

	public static int GetMaxLevel(int groupId, int subId, HeroConfig config)
	{
		return 0;
	}

	public static int GetMaxExpReached(int groupId, int subId, HeroConfig config)
	{
		return 0;
	}

	public static MainCharacterData GetMainCharacterData()
	{
		return null;
	}

	public static int GetExpNeedToUpToLevel(int groupId, int subId, int level)
	{
		return 0;
	}

	public static HeroData GenerateHeroDataWithoutEquipment(MainCharacterData mainCharacter, int characterLevel)
	{
		return null;
	}

	public static HeroData GenerateHeroDataWithEquipment(MainCharacterData mainCharacter, int characterLevel)
	{
		return null;
	}

	public static int GetChacterLevelHighest(UserData userData)
	{
		return 0;
	}

	public static int GetCharacterTotalPower(MainCharacterData mainCharacterData)
	{
		return 0;
	}

	public static MainCharacterData GetTutorialMainCharacterData()
	{
		return null;
	}
}
