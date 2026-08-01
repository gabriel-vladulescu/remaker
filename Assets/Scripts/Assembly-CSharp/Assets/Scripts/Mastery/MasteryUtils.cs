using System.Collections.Generic;
using Scripts.Config;
using Ssar.Rune.Model;

namespace Assets.Scripts.Mastery
{
	public static class MasteryUtils
	{
		private static MasteryConfig masteryConfig;

		public static List<MasteryInfo> GetMasteryInfos(ConfigManager configManager = null)
		{
			return null;
		}

		public static List<MasteryLevelUpInfo> GetMasteryLevelUpInfos(MasteryInfo masteryInfo, ConfigManager configManager = null)
		{
			return null;
		}

		public static int GetMasteryLevel(MasteryInfo masteryInfo, MainCharacterData mainCharacterData)
		{
			return 0;
		}

		public static int GetMasteryLevel(MasteryInfo masteryInfo, MasteryData masteryData)
		{
			return 0;
		}

		public static void GetMasteryStatDesc(int level, MasteryInfo masteryInfo, out string statType, out string value)
		{
			statType = null;
			value = null;
		}

		public static string GetMasteryStatDescWithCharacterLevel(int masteryLevel, int characterLevel, MasteryInfo masteryInfo)
		{
			return null;
		}

		public static bool IsMaxLevel(int masterLevel, MasteryInfo masteryInfo)
		{
			return false;
		}

		public static int GetMasteryMaxLevel(MasteryInfo masteryInfo)
		{
			return 0;
		}

		public static MasteryLevelUpInfo GetMasteryLevelUpInfo(int level, MasteryInfo masteryInfo)
		{
			return null;
		}

		public static MasteryConfig GetMasteryConfig(ConfigManager configManager = null)
		{
			return null;
		}

		public static float GetMasteryLvProgress(int exp, MasteryInfo masteryInfo)
		{
			return 0f;
		}

		public static int GetExpRequire(MasteryLevelUpInfo levelUpInfo)
		{
			return 0;
		}

		public static int ConvertToExp(RuneRarity runeRarity)
		{
			return 0;
		}

		public static int GetTotalMasteryLevel(MainCharacterData mainCharacterData)
		{
			return 0;
		}

		public static void ValidateMasteryData(MainCharacterData mainCharacterData, ConfigManager configManager)
		{
		}

		public static void SetTotalMasteryLevel(int totalLevel, MainCharacterData mainCharacterData, ConfigManager configManager)
		{
		}
	}
}
