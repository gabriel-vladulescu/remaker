using SSAR.Equipment.Enum;

namespace Assets.Scripts.Ssar.Equipment
{
	public interface EquipmentDropConfig
	{
		bool FindMainStatsConfigOf(EquipmentType equipmentType, EquipmentTier grade, Rarity rarity, ref StatsConfig statsConfig);

		bool FindBonusStatsCount(EquipmentType equipmentType, Rarity rarity, ref int[] statsCount);

		StatType[] FindAvailableStatTypesForBonusStats(EquipmentType equipmentType);

		bool FindWeaponActiveSkill(int characterGroupId, int characterSubId, EquipmentType equipmentType, int grade, Rarity rarity, ref WeaponActiveSkillConfig weaponActiveSkill);

		bool FindWeaponPassiveSkill(int characterGroupId, int characterSubId, EquipmentType equipmentType, int grade, Rarity rarity, ref WeaponPassiveSkillConfig weaponPassiveSkill);

		bool IsPassiveSkillAvailableForWeaponOf(Rarity rarity);

		bool FindStatsConfigOfBonusStats(EquipmentType equipmentType, StatType statType, Rarity rarity, ref StatsConfig statsConfig);

		int GetRuneSlotCount(EquipmentType equipmentType, Rarity rarity);

		int GetMaxRuneSlotCount(EquipmentType equipmentType, Rarity rarity);

		bool FindAncientActiveSkill(EquipmentType equipmentType, int grade, Rarity rarity, ref AncientActiveSkillConfig ancientActiveSkill);
	}
}
