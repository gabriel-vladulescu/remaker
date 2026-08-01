using System;
using System.Collections.Generic;
using Assets.Scripts.Config.Stats;
using Assets.Scripts.Utils;
using SSAR.Entry.Model;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using Scripts.Config;
using Scripts.Config.Stats;
using UnityEngine;

namespace Scripts.Ssar.Pet
{
	public static class PetUtilities
	{
		public static List<string> PetAINames()
		{
			return null;
		}

		public static PetCollectData GetPetStrongerThanCurrentEquipped(MainCharacterData mainCharacterData)
		{
			return null;
		}

		public static PetCollectData GetCurrentPetEquipped(MainCharacterData mainCharacterData)
		{
			return null;
		}

		public static bool IsPetStronger(PetCollectData current, PetCollectData target)
		{
			return false;
		}

		public static ComparerItemResult ComparerTwoEquipment(PetCollectData a, PetCollectData b)
		{
			return null;
		}

		private static void Comparer(List<ShowSubStatParameter> compareA, List<ShowSubStatParameter> compareB)
		{
		}

		public static List<ShowSubStatParameter> GetnerateShowSubStatParameters(PetCollectData collectData)
		{
			return null;
		}

		private static List<ShowSubStatParameter> GenerateMainStatParameter(PetCollectData collectData)
		{
			return null;
		}

		private static void SetComparerResult(int index, List<ShowSubStatParameter> parameters, float diff)
		{
		}

		public static List<EquipmentStat> GetEquipmentMainStatFinal(PetConfigId configId, int enhanceLevel, int awakenExp, PetConfig petConfig)
		{
			return null;
		}

		public static List<EquipmentStat> GetEquipmentMainStatWithEnhance(PetConfigId configId, int enhanceLevel, PetConfig petConfig)
		{
			return null;
		}

		public static float GetAwakenMainStatBonus(int awakenLv)
		{
			return 0f;
		}

		public static int GetAwakenMaxLevel(ConfigManager configManager = null)
		{
			return 0;
		}

		public static List<EquipmentStat> GetEquipmentSubStatsAwaken(PetCollectData collectData)
		{
			return null;
		}

		public static List<EquipmentStat> GetEquipmentSubStatsRaw(PetConfigId equipmentConfigId)
		{
			return null;
		}

		public static float GetAwakenSubStatBonus(int awakenLv)
		{
			return 0f;
		}

		public static int GetAwakenLevel(PetCollectData petCollectData)
		{
			return 0;
		}

		public static float GetAwakenLvProgress(int exp, Rarity rarity, EquipmentTier tier, ConfigManager configManager = null)
		{
			return 0f;
		}

		public static int GetEquipmentEnhanceMaxLevel(EquipmentTier tier, Rarity rarity, PetConfig equipmentConfig)
		{
			return 0;
		}

		public static int GetEquipmentAwakenExpLevelRequire(Rarity rarity, EquipmentTier tier, ConfigManager configManager = null)
		{
			return 0;
		}

		public static int GetEquipmentAwakenSoulPricePerSlot(Rarity rarity, EquipmentTier tier)
		{
			return 0;
		}

		public static int GetEquipmentAwakenMaterialExp(int expAwaken, Rarity rarity, EquipmentTier tier)
		{
			return 0;
		}

		public static int GetEquipmentSellPrice(PetConfigId configId, int enhanceLevel, int awakenLevel, PetConfig config)
		{
			return 0;
		}

		public static int GetEquipmentSellPriceBeforeDivide(PetConfigId configId, int enhanceLevel, int awakenLevel, PetConfig config)
		{
			return 0;
		}

		public static int GetEquipmnetAwakenSellPrice(PetConfigId equipmentConfigId, int awakenLevel)
		{
			return 0;
		}

		public static int GetEnhanceEquipmentPriceFromLv1ToLevel(PetConfigId configId, int targetLevelEnhance, PetConfig equipmentConfig)
		{
			return 0;
		}

		public static int GetEnhanceEquipmentPrice(PetConfigId configId, int targetLevelEnhance, PetConfig equipmentConfig)
		{
			return 0;
		}

		public static EntityAbilities GeneratePetAbilities(PetCollectData petCollectData)
		{
			return null;
		}

		public static void GetShareStatSkillIcon(ShareStatType shareStatType, ref UISprite icon)
		{
		}

		public static EquipmentCollectData GetEquipmentEquippedInSlot(MainCharacterData mainCharacterData, PetCollectData petCollectData, EquipmentType type)
		{
			return null;
		}

		public static void GetPetSkillIcon(PetSkillStats skillStat, ref UISprite icon)
		{
		}

		public static bool IsEquippedEquipment(MainCharacterData mainCharacterData, int equipmentCollectId)
		{
			return false;
		}

		public static int GetEquipppedEquipmentCollectId(MainCharacterData mainCharacterData, PetCollectData petCollectData, EquipmentType type)
		{
			return 0;
		}

		public static PetData GeneratePetData(MainCharacterData mainCharacterData, PetCollectData petCollectData)
		{
			return null;
		}

		public static EquipmentType[] GetEquipmentTypes()
		{
			return null;
		}

		public static void GetShareStatInfo(PetShareStat petShareStat, PetData petData, out string desc, out string name)
		{
			desc = null;
			name = null;
		}

		public static double GetStatValue(ShareStatType shareStatType, EntityAbilities abilities)
		{
			return 0.0;
		}

		public static void LoadPetPreview(MainCharacterData mainCharacterData, LoadModelLogic loadModelLogic, Vector3 characterPos, Vector3 rotation)
		{
		}

		public static void LoadPetPreview(PetCollectData petCollectData, LoadModelLogic loadModelLogic, Vector3 characterPos, Vector3 rotation)
		{
		}

		public static void LoadPetPreview(PetConfigId petConfigId, LoadModelLogic loadModelLogic, Vector3 characterPos, Vector3 rotation, Action<GameObject> callback = null)
		{
		}

		public static List<EquipmentCollectData> GetListequipmentStrongerThanCurrentEquippedEquipment(PetCollectData petCollectData, MainCharacterData mainCharacter)
		{
			return null;
		}

		public static List<EquipmentCollectData> GetListEquipmentEquipped(PetCollectData petCollectData, MainCharacterData mainCharacterData)
		{
			return null;
		}
	}
}
