using System.Collections.Generic;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using SSAR.SkillSystem.Model;
using Scripts.Config;
using Ssar.Ancient.Model;

public static class AncientUtils
{
	public static AncientEquipmentConfig Config()
	{
		return null;
	}

	public static AncientEnhancementConfig EnhancementConfig()
	{
		return null;
	}

	public static bool IsFeatureEnabled()
	{
		return false;
	}

	public static string GetAIName(AncientEquipmentConfig config, int skillId)
	{
		return null;
	}

	public static string GetAIName(AncientEquipmentConfig configManager, AncientSkill ancientSkill)
	{
		return null;
	}

	public static List<string> GetAINames(AncientEquipmentConfig configManager)
	{
		return null;
	}

	public static float GetPowerLevelProgressWithMaterials(EquipmentCollectData equipmentCollectData, List<EquipmentCollectData> materials)
	{
		return 0f;
	}

	public static int GetTotalMaterialExp(List<EquipmentCollectData> materials)
	{
		return 0;
	}

	public static int GetEnhanceSoulCost(EquipmentCollectData equipmentCollectData, int targetLv, int materialCount)
	{
		return 0;
	}

	private static float GetAncientSkillLevelProgress(ChargedAncientSkill skillData, int maxLevel)
	{
		return 0f;
	}

	private static int GetExpRequire(AncientExpInfo expInfo)
	{
		return 0;
	}

	private static int ConvertToExp(Rarity rarity)
	{
		return 0;
	}

	public static AncientActiveSkillStat GetActiveSkillStat(int id, int level)
	{
		return null;
	}

	public static SkillExtraStatConfig GetSkillExtraStatConfig(SkillExtraStatType type)
	{
		return null;
	}

	public static string GetSkillFullTitle(ChargedAncientSkill skillData)
	{
		return null;
	}

	public static string GetSkillDesc(ChargedAncientSkill skillData, bool fullDesc = true)
	{
		return null;
	}

	public static string FormatStatValue(SkillExtraStatConfig statConfig, double stat, bool hasExtra = true)
	{
		return null;
	}

	public static double GetSkillPower(ChargedAncientSkill skillData)
	{
		return 0.0;
	}

	public static string GetSkillFullTitleMinMaxTierAtLevel1(ChargedAncientSkill skillData, EquipmentTier min, EquipmentTier max)
	{
		return null;
	}

	public static string GetSkillMinMaxTierAtLevel1Desc(ChargedAncientSkill skillData, EquipmentTier min, EquipmentTier max)
	{
		return null;
	}

	private static double GetPower(ChargedAncientSkill skillData, AncientActiveSkillStat stat)
	{
		return 0.0;
	}

	public static int GetSkillPowerLevel(EquipmentCollectData collectData)
	{
		return 0;
	}

	public static int GetMaxSkillPowerLevel(EquipmentCollectData collectData)
	{
		return 0;
	}

	public static int GetMaxCharge(string skillFullId, int level)
	{
		return 0;
	}

	public static List<ChargedAncientSkill> GetListAncientSkillEquipped(MainCharacterData mainCharacterData)
	{
		return null;
	}

	public static bool IsSameAncientSkill(EquipmentCollectData equipment1, EquipmentCollectData equipment2)
	{
		return false;
	}

	public static bool IsAncientSkill(SkillConfigId skillConfigId)
	{
		return false;
	}

	public static bool IsAncientSkill(string skillId)
	{
		return false;
	}

	public static int GetEnhancedLevel(ChargedAncientSkill skillData, int maxLevel)
	{
		return 0;
	}

	public static double GetAncientSkillPower(ChargedAncientSkill skillData, AncientActiveSkillStat skillStat)
	{
		return 0.0;
	}

	public static double GetAncientSkillPower(AncientActiveSkillStat skillStat, int enhancedLevel)
	{
		return 0.0;
	}

	public static SkillExtraStat[] GetAncientSkillExtraStats(AncientActiveSkillStat skillStat, int enhancedLevel)
	{
		return null;
	}

	public static double GetCooldown(AncientActiveSkillStat skillStat, int enhancedLevel)
	{
		return 0.0;
	}

	public static void ValidateAncientSkills(MainCharacterData mainCharacterData)
	{
	}

	private static void ValidateAncientSkill(EquipmentConfigId equipmentConfigId)
	{
	}

	public static SlotType[] AncientSlotTypes()
	{
		return null;
	}

	public static EquipmentCollectData[] GetEquippedAncients(MainCharacterData mainCharacterData)
	{
		return null;
	}

	public static List<EquipmentCollectData> GetListAncientToFillInEquipped(MainCharacterData mainCharacter)
	{
		return null;
	}

	public static List<SlotType> GetEmptyAncientSlot(MainCharacterData mainCharacter)
	{
		return null;
	}

	public static void ValidateAncientSlot(MainCharacterData mainCharacterData)
	{
	}
}
