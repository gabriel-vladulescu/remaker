using System.Collections.Generic;
using Assets.Scripts.Config.Stats;
using Assets.Scripts.Mastery;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using Scripts.Config;
using Scripts.Config.Stats;

namespace Assets.Scripts.Utils
{
	public static class EntityStatMapTool
	{
		private static Dictionary<GetBasicAbilitiesParameter, EntityAbilities> dictBasicAbilitieses;

		private static Dictionary<GetHeroAndEquipmentAbilities, EntityAbilities> dictHeroAndEquipmentAbilities;

		private static ConfigManager configManager;

		public static void ClearCache()
		{
		}

		public static void SetConfigManager(ConfigManager config)
		{
		}

		public static EntityAbilities GetBasicAbilities(GetBasicAbilitiesParameter parameter)
		{
			return null;
		}

		public static EntityAbilities GetHeroAndEquipmentAbilities(GetHeroAndEquipmentAbilities parameter)
		{
			return null;
		}

		private static void BonusStatFromMastery(ref EntityAbilities abilities, MasteryData masteryData)
		{
		}

		private static void BonusStatFromPet(ref EntityAbilities abilities, PetData petData)
		{
		}

		private static void BonusStatsFromRunes(EquipmentCollectData equipment, RuneConfig rc, EntityAbilities m_basicAbilites)
		{
		}

		private static void BonusStatsFromPassiveSkills(EntityAbilities mBasicAbilites, EquipmentCollectData equipment, int groupId, int subId)
		{
		}

		public static void AddStat(StatType type, double value, ref EntityAbilities abilities)
		{
		}

		private static ConfigManager ConfigManager()
		{
			return null;
		}
	}
}
