using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Scripts.Config;
using Scripts.Config.Stats;

public static class SkillDataUtils
{
	public static void GenerateSkillDataInit(CharacterInitData CharacterInitData, ref MainCharacterData mainCharacterData, Preset preset)
	{
	}

	public static List<int> GetListActiveSkillEquipped(MainCharacterData mainCharacterData, Preset preset)
	{
		return null;
	}

	public static void AutoGenerateActiveSkillEquippedWithCurrentLevel(MainCharacterData mainCharacterData, Preset preset)
	{
	}

	public static double GetRuneValue(int runLevel, double baseValue, double[] arrayRuneValues)
	{
		return 0.0;
	}

	public static MainCharacterData CloneMainCharacterData(MainCharacterData mainCharacterData, Preset preset)
	{
		return null;
	}

	public static int GetSkillPointByLevel(MainCharacterData mainCharacterData)
	{
		return 0;
	}

	public static int GetSkillPointByPurchased(MainCharacterData mainCharacterData)
	{
		return 0;
	}

	public static int GetSkillPointRemaining(MainCharacterData mainCharacterData, Preset preset)
	{
		return 0;
	}

	public static int GetSkillPointTotal(MainCharacterData mainCharacterData)
	{
		return 0;
	}

	public static bool HasModifyCharacterSkillData(MainCharacterData mainCharacterData, Preset preset)
	{
		return false;
	}

	public static bool IsUnlotSkillSlot(MainCharacterData mainCharacterData, int slot)
	{
		return false;
	}

	public static int GetLevelRequireToUnlockSkillSlot(MainCharacterData mainCharacterData, int slot)
	{
		return 0;
	}

	public static CharacterActiveSkillStat GetCharacterActiveSkillStatDefaultInSlot(MainCharacterData mainCharacterData, int slot)
	{
		return null;
	}

	public static List<CharacterSignatureSkillStat> GetListSignatureSkillStatsAvailableWithLevel(int groupId, int subId, int level)
	{
		return null;
	}

	public static bool IsComboAttack2Available(int groupId, int subId, int level)
	{
		return false;
	}

	public static bool IsComboAttack3Available(int groupId, int subId, int level)
	{
		return false;
	}

	public static bool IsComboAttack4Available(int groupId, int subId, int level)
	{
		return false;
	}

	public static bool IsDashAttackAvailable(int groupId, int subId, int level)
	{
		return false;
	}

	public static bool IsJumpAttack1Available(int groupId, int subId, int level)
	{
		return false;
	}

	public static bool IsJumpAttack2Available(int groupId, int subId, int level)
	{
		return false;
	}

	public static bool IsDashAvailable(int groupId, int subId, int level)
	{
		return false;
	}

	public static List<CharacterActiveSkillStat> GetListActiveSkillAvailableWithLevel(int groupId, int subId, int level)
	{
		return null;
	}

	public static List<int> GetListActiveSkillAvailableWithLevel(MainCharacterData mainCharacterData)
	{
		return null;
	}

	public static List<CharacterActiveSkillStat> GetListActiveSkillEquipped(MainCharacterData mainCharacterData, ConfigManager configManager, Preset preset)
	{
		return null;
	}

	public static List<CharacterPassiveSkillStat> GetListPassiveSkillAvailableWithLevel(int groupId, int subId, int level)
	{
		return null;
	}

	public static void GetNewSkillUnlocked(int groupId, int subId, int levelBefore, int levelAfter, out List<ISkillStat> active, out List<ISkillStat> signature, out List<ISkillStat> passive)
	{
		active = null;
		signature = null;
		passive = null;
	}

	private static List<ISkillStat> ComparerSkill<T>(List<T> before, List<T> after) where T : ISkillStat
	{
		return null;
	}

	public static void ApplyPassiveSkill(int groupdId, int subId, int characterLevel, SkillEquippedData skillData, ref EntityAbilities abilities)
	{
	}

	public static bool IsUltimateSkill(string skillId)
	{
		return false;
	}

	public static float GetCharacter4Skill7ConfigValue()
	{
		return 0f;
	}

	public static SkillEquippedData GetSkillEquippedData(MainCharacterData mainCharacterData, IBattleModeLogic battleModeLogic)
	{
		return null;
	}

	public static SkillEquippedData GetSkillEquippedData(MainCharacterData mainCharacterData, Preset preset)
	{
		return null;
	}
}
