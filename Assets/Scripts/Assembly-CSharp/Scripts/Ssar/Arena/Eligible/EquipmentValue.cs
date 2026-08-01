using SSAR.Equipment.Enum;
using Scripts.Config;

namespace Scripts.Ssar.Arena.Eligible
{
	public class EquipmentValue : IEligibleValue
	{
		private MainCharacterData mainCharacterData;

		private ConfigManager configManager;

		private JsonEquipmentDropConfig _jsonEquipmentDropConfig;

		private JsonCosmeticEquipmentDropConfig _jsonCosmeticEquipmentDropConfig;

		private AncientEquipmentConfig _ancientEquipmentConfig;

		public EquipmentValue(MainCharacterData mainCharacterData, ConfigManager configManager)
		{
		}

		public int Value()
		{
			return 0;
		}

		private int Equipment()
		{
			return 0;
		}

		private bool IsHighItem(EquipmentType equipmentType)
		{
			return false;
		}

		private int ValidateStat(EquipmentConfigId equipmentConfigId)
		{
			return 0;
		}

		private JsonEquipmentDropConfig JsonEquipmentDropConfig(int group)
		{
			return null;
		}

		private JsonEquipmentDropConfig.MainStats findMainStats(EquipmentType equipmentType, EquipmentTier grade, Rarity rarity)
		{
			return null;
		}

		private JsonEquipmentDropConfig.BonusStatsValue findBonusStatsValue(EquipmentType equipmentType, Rarity rarity, StatType statType)
		{
			return null;
		}
	}
}
