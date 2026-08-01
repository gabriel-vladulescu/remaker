using System.Collections.Generic;
using System.Reflection;
using Assets.Scripts.Model;
using Assets.Scripts.Ssar.Entry;
using SSAR.Entry.Model;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using Scripts.Config;
using UnityEngine;

public static class EquipmentTools
{
	private static Dictionary<StatType, PropertyInfo> cachePropertyInfos;

	public static EquipmentCollectData GetEquipmentEquippedInSlot(MainCharacterData mainCharacterData, EquipmentType type, SlotType slotType = SlotType.DEFAULT)
	{
		return null;
	}

	public static ShowItemComparerParameter GeneratEquipmentComparerParameter(EquipmentCollectData left, EquipmentCollectData right, EquipmentTarget equipmentTarget, bool showLeft)
	{
		return null;
	}

	public static EquipmentStat[] SortEquipmentStats(EquipmentStat[] stats)
	{
		return null;
	}

	public static EquipmentStat[] GetEquipmentSubStatsAwaken(EquipmentCollectData collectData)
	{
		return null;
	}

	public static EquipmentStat[] GetEquipmentSubStatsRaw(EquipmentConfigId equipmentConfigId)
	{
		return null;
	}

	public static ShowSubStatParameter[] GetnerateShowSubStatParameters(EquipmentCollectData collectData)
	{
		return null;
	}

	public static ShowSubStatParameter GenerateMainStatParameter(EquipmentCollectData collectData)
	{
		return null;
	}

	public static ComparerItemResult ComparerTwoEquipment(EquipmentCollectData a, EquipmentCollectData b)
	{
		return null;
	}

	public static List<EquipmentCollectData> GetListequipmentStrongerThanCurrentEquippedEquipment(MainCharacterData mainCharacter)
	{
		return null;
	}

	public static bool IsEquippedEquipment(MainCharacterData mainCharacterData, int equipmentCollectId)
	{
		return false;
	}

	public static EquipmentCategory GetEquipmentCategory(EquipmentType type)
	{
		return default(EquipmentCategory);
	}

	public static EquipmentCombinedType GetEquipmentCombinedType(EquipmentType type)
	{
		return default(EquipmentCombinedType);
	}

	public static int GetEnhanceEquipmentPrice(EquipmentConfigId configId, int targetLevelEnhance, EquipmentConfig equipmentConfig)
	{
		return 0;
	}

	public static int GetEnhanceEquipmentPriceFromLv1ToLevel(EquipmentConfigId configId, int targetLevelEnhance, EquipmentConfig equipmentConfig)
	{
		return 0;
	}

	public static int GetEquipmentSellPrice(EquipmentConfigId configId, int enhanceLevel, int awakenLevel, EquipmentConfig config)
	{
		return 0;
	}

	public static int GetEquipmentSellPriceBeforeDivide(EquipmentConfigId configId, int enhanceLevel, int awakenLevel, EquipmentConfig config)
	{
		return 0;
	}

	public static int GetEquipmnetAwakenSellPrice(EquipmentConfigId equipmentConfigId, int awakenLevel)
	{
		return 0;
	}

	public static EquipmentStat GetEquipmentMainStatWithEnhance(EquipmentConfigId configId, int enhanceLevel, EquipmentConfig config)
	{
		return null;
	}

	public static EquipmentStat GetEquipmentMainStatFinal(EquipmentConfigId configId, int enhanceLevel, int awakenExp, EquipmentConfig config, AwakenEquipmentConfig awakenEquipmentConfig)
	{
		return null;
	}

	public static double GetEquipmentEnhanceStatConstantB(EquipmentConfigId configId, EquipmentConfig config)
	{
		return 0.0;
	}

	public static int GetEquipmentEnhanceMaxLevel(EquipmentType equipmentType, EquipmentTier tier, Rarity rarity, EquipmentConfig equipmentConfig)
	{
		return 0;
	}

	public static bool IsMaxEnhanceLevel(int currentLevel, EquipmentType equipmentType, EquipmentTier tier, Rarity rarity, EquipmentConfig equipmentConfig)
	{
		return false;
	}

	public static int GetCurrentInventorySlot(MainCharacterData mainCharacterData, InventoryExpandConfig config)
	{
		return 0;
	}

	public static int GetMaxInventoryExpandLevel(InventoryExpandConfig config)
	{
		return 0;
	}

	public static int GetNumOfEquipmentInInventory()
	{
		return 0;
	}

	public static EquipmentStatData GetStats(EquipmentConfigId configId, int enhanceLevel, int awakenExp)
	{
		return null;
	}

	public static EquipmentStatData GenerateEquipmentStatData(List<EquipmentStat> stats)
	{
		return null;
	}

	public static EquipmentConfigId ValidateEquipmentHasGenerated(EquipmentConfigId equipmentConfigId, EquipmentVisualConfig equipmentConfig, string visualCategory, List<VisualId> visualIdPrefer = null, List<VisualId> visualIdsIgnore = null)
	{
		return null;
	}

	public static EquipmentConfigId ValidateEquipmentStatsHasGenerated(EquipmentConfigId equipmentConfigId)
	{
		return null;
	}

	public static JsonEquipmentDropConfig GetJsonEquipmentDropConfig(int groupId)
	{
		return null;
	}

	public static JsonEquipmentDropConfig GetJsonEquipmentDropConfig(ConfigManager configManager, int groupId, int subId)
	{
		return null;
	}

	public static int GetAwakenLv(IItem collectData, ConfigManager configManager = null)
	{
		return 0;
	}

	public static int GetAwakenLv(int exp, Rarity rarity, EquipmentTier tier, ConfigManager configManager = null)
	{
		return 0;
	}

	public static float GetAwakenLvProgress(int exp, Rarity rarity, EquipmentTier tier, ConfigManager configManager = null)
	{
		return 0f;
	}

	public static int GetEquipmentAwakenMaterialExp(int expAwaken, Rarity rarity, EquipmentTier tier)
	{
		return 0;
	}

	public static int GetEquipmentAwakenExpLevelRequire(Rarity rarity, EquipmentTier tier, ConfigManager configManager = null)
	{
		return 0;
	}

	public static int GetEquipmentAwakenSoulPricePerSlot(EquipmentType equipmentType, Rarity rarity, EquipmentTier tier)
	{
		return 0;
	}

	public static float GetAwakenMainStatBonus(int awakenLv)
	{
		return 0f;
	}

	public static float GetAwakenSubStatBonus(int awakenLv)
	{
		return 0f;
	}

	public static int GetAwakenMaxLevel(ConfigManager configManager = null)
	{
		return 0;
	}

	public static AwakenLevelView InstantiateAwakenLevelView(GameObject parent, Vector3 position)
	{
		return null;
	}

	public static MainCharacterData ValidateEquipmentStat(MainCharacterData mainCharacterData)
	{
		return null;
	}

	public static EquipmentConfigId ValidateEquipmentStat(int characterGroupId, EquipmentConfigId equipmentConfigId)
	{
		return null;
	}

	public static AbsCharacterGenerateEquipmentLogic GenerateEquipmentLogic(int groupId)
	{
		return null;
	}

	private static int GenerateVisualId(EquipmentVisualConfig equipmentConfig, EquipmentConfigId equipmentConfigId, string visualCategory, List<VisualId> visualIdPrefer)
	{
		return 0;
	}

	public static void GetStatOnVisual(StatType type, out double multiplier, out string ext)
	{
		multiplier = default(double);
		ext = null;
	}

	public static bool GetEquipmentVisualInfo(MainCharacterData mainCharacterData, EquipmentType equipmentType, bool checkEnableVisual, out CharacterVisualInfo characterVisualInfo)
	{
		characterVisualInfo = null;
		return false;
	}

	public static bool IsCosmeticEquipment(EquipmentType equipmentType)
	{
		return false;
	}

	public static bool GetCosmeticWingVisualId(MainCharacterData mainCharacterData, ref int visualId, ref Rarity rarity)
	{
		return false;
	}

	public static List<EquipmentSkillInfo> GetWeaponEquipmentActiveSkillInfo(MainCharacterData mainCharacterData)
	{
		return null;
	}

	public static bool IsEnhancedSkill(CharacterActiveSkillStat characterActiveSkillStat, MainCharacterData mainCharacterData, HeroConfig heroConfig, JsonEquipmentDropConfig jsonEquipmentDropConfig)
	{
		return false;
	}

	public static bool GetEquipmentSkilInfoWithSkill(MainCharacterData mainCharacterData, CharacterActiveSkillStat characterActiveSkillStat, ConfigManager configManager, ref EquipmentSkillInfo equipmentSkillInfo)
	{
		return false;
	}

	private static void SetPropertyValue(PropertyInfo property, object obj, object value)
	{
	}

	public static UISfx GetSfxEquipEquipment(EquipmentCategory category)
	{
		return default(UISfx);
	}

	public static UISfx GetSfxUnEquipEquipment(EquipmentCategory category)
	{
		return default(UISfx);
	}

	public static StatType GetStatType(EquipmentType equipmentType)
	{
		return default(StatType);
	}

	public static bool IsEquipmentStronger(EquipmentCollectData current, EquipmentCollectData target)
	{
		return false;
	}

	public static List<EquipmentType> GetListEquipmentTypes()
	{
		return null;
	}

	private static void SetComparerResult(int index, ShowSubStatParameter[] parameters, float diff)
	{
	}

	private static int ComparerStatType(EquipmentStat a, EquipmentStat b)
	{
		return 0;
	}
}
