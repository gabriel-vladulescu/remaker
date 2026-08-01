using SSAR.Equipment.Enum;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Equipment
{
	public class DefaultEquipmentDropConfig : EquipmentDropConfig
	{
		private class DefaultStatsConfig : StatsConfig
		{
			private StatType statType;

			private JsonEquipmentDropConfig.MainStats mainStats;

			public DefaultStatsConfig(StatType statType, JsonEquipmentDropConfig.MainStats mainStats)
			{
			}

			public StatType Type()
			{
				return default(StatType);
			}

			public float[] Range()
			{
				return null;
			}
		}

		private class BonusStatsValueToStatsConfigAdapter : StatsConfig
		{
			private JsonEquipmentDropConfig.BonusStatsValue bonusStatsValue;

			public BonusStatsValueToStatsConfigAdapter(JsonEquipmentDropConfig.BonusStatsValue bonusStatsValue)
			{
			}

			public StatType Type()
			{
				return default(StatType);
			}

			public float[] Range()
			{
				return null;
			}
		}

		private JsonEquipmentDropConfig rawJsonEquipmentDropConfig;

		private JsonCosmeticEquipmentDropConfig rawJsonCosmeticEquipmentDropConfig;

		private AncientEquipmentConfig ancientEquipmentConfig;

		private GameConfigConstant gameConfigConstant;

		public DefaultEquipmentDropConfig(JsonEquipmentDropConfig rawJsonEquipmentDropConfig, JsonCosmeticEquipmentDropConfig rawJsonCosmeticEquipmentDropConfig, AncientEquipmentConfig ancientEquipmentConfig, GameConfigConstant gameConfigConstant)
		{
		}

		public bool FindMainStatsConfigOf(EquipmentType equipmentType, EquipmentTier grade, Rarity rarity, ref StatsConfig statsConfig)
		{
			return false;
		}

		public bool FindBonusStatsCount(EquipmentType equipmentType, Rarity rarity, ref int[] statsCount)
		{
			return false;
		}

		public StatType[] FindAvailableStatTypesForBonusStats(EquipmentType equipmentType)
		{
			return null;
		}

		public bool FindWeaponPassiveSkill(int characterGroupId, int characterSubId, EquipmentType equipmentType, int grade, Rarity rarity, ref WeaponPassiveSkillConfig weaponPassiveSkill)
		{
			return false;
		}

		public bool IsPassiveSkillAvailableForWeaponOf(Rarity rarity)
		{
			return false;
		}

		public bool FindStatsConfigOfBonusStats(EquipmentType equipmentType, StatType statType, Rarity rarity, ref StatsConfig statsConfig)
		{
			return false;
		}

		public bool FindWeaponActiveSkill(int characterGroupId, int characterSubId, EquipmentType equipmentType, int grade, Rarity rarity, ref WeaponActiveSkillConfig weaponActiveSkill)
		{
			return false;
		}

		public bool FindAncientActiveSkill(EquipmentType equipmentType, int grade, Rarity rarity, ref AncientActiveSkillConfig ancientActiveSkill)
		{
			return false;
		}

		public bool FindStatsConfigOfBonusStats(StatType statType, Rarity rarity, ref StatsConfig statsConfig)
		{
			return false;
		}

		public int GetRuneSlotCount(EquipmentType equipmentType, Rarity rarity)
		{
			return 0;
		}

		public int GetMaxRuneSlotCount(EquipmentType equipmentType, Rarity rarity)
		{
			return 0;
		}
	}
}
