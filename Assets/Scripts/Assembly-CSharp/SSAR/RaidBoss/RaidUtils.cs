using System.Collections.Generic;
using SSAR.BattleSystem.System.Arena.Api;
using Scripts.Config;
using Ssar.RaidBoss.API;

namespace Ssar.RaidBoss
{
	public static class RaidUtils
	{
		private static int CYCLE;

		private static readonly RaidDifficulty[] Difficulties;

		public static RaidBossConfig GetConfig()
		{
			return null;
		}

		public static RaidBossConfig.Constants GetConstants()
		{
			return null;
		}

		public static ScenarioDifficulty HighestDifficulty()
		{
			return default(ScenarioDifficulty);
		}

		public static int MaxContributor()
		{
			return 0;
		}

		public static bool IsDisableSingleModeReward()
		{
			return false;
		}

		public static RaidDifficulty[] GetAllDifficulties()
		{
			return null;
		}

		public static RaidDifficulty[] GetAvailableDifficulties()
		{
			return null;
		}

		public static void CheckUnlockRaid()
		{
		}

		public static string GetErrorMessage(StatusCode statusCode)
		{
			return null;
		}

		public static Ssar.RaidBoss.API.HttpEndPoints GetHttpEndPoints()
		{
			return null;
		}

		public static RaidDifficulty GetDefaultDifficulty()
		{
			return default(RaidDifficulty);
		}

		public static string GetDefaultUserId()
		{
			return null;
		}

		public static string GetUserId(MainCharacterData characterData)
		{
			return null;
		}

		public static int GetPowerRecommend(RaidDifficulty difficulty)
		{
			return 0;
		}

		public static int GetBaseKill(RaidDifficulty difficulty)
		{
			return 0;
		}

		public static int GetPower(MainCharacterData characterData)
		{
			return 0;
		}

		public static int GetBossPower()
		{
			return 0;
		}

		public static string GetRaidBossRoomName(RaidBossConfig.Room room)
		{
			return null;
		}

		public static RaidBossConfig.GlobalReward GetCurrentGlobalReward(RaidDifficulty difficulty)
		{
			return null;
		}

		public static RaidBossConfig.GlobalReward GetMaxGlobalReward(RaidDifficulty difficulty)
		{
			return null;
		}

		public static RaidBossConfig.GlobalReward[] GetAvailableCheckpointRewards(RaidDifficulty difficulty)
		{
			return null;
		}

		public static string GlobalKillFormat(RaidBossConfig.GlobalReward globalReward, int baseKill)
		{
			return null;
		}

		public static List<ItemInfo> GetCurrentSeasonalRewards(RaidDifficulty difficulty, int seasonId, int rank)
		{
			return null;
		}

		public static List<ItemInfo> GetPreviousSeasonalRewards(RaidDifficulty difficulty, int seasonId, int rank, int globalKill)
		{
			return null;
		}

		public static List<ItemInfo> GetSeasonalRewardsByGlobalProgress(RaidDifficulty difficulty, int seasonId, int rank, int globalKill)
		{
			return null;
		}

		private static RaidBossConfig.GlobalReward GetGlobalReward(RaidDifficulty difficulty, int globalKill)
		{
			return null;
		}

		public static List<ItemInfo> GenerateGlobalRewards(RaidBossConfig.GlobalReward globalReward)
		{
			return null;
		}

		public static ItemInfo ConvertBattleRewardToItemInfo(ConfigManager configManager, RaidBossConfig.BattleReward reward)
		{
			return null;
		}

		private static int Comparer(RaidBossConfig.GlobalReward a, RaidBossConfig.GlobalReward b)
		{
			return 0;
		}

		public static string GetCurrentSeasonName(int seasonCount)
		{
			return null;
		}

		public static string GetPreviousSeasonName()
		{
			return null;
		}

		public static void GetPreviousSeasonIcon(UISprite sprite)
		{
		}

		public static void GetCurrentSeasonIcon(UISprite sprite)
		{
		}

		public static void GetSeasonIcon(UISprite sprite, int seasonCount)
		{
		}

		public static void GetPreviousSeasonBg(UISprite sprite)
		{
		}

		public static void GetCurrentSeasonBg(UISprite sprite)
		{
		}

		public static void GetSeasonBg(UISprite sprite, int seasonCount)
		{
		}

		public static void GetRaidRankIcon(int rank, ref UISprite sprite)
		{
		}

		public static void GetRaidRankName(int rank, ref UILabel label)
		{
		}

		public static void KickOut(StatusCode statusCode, string message)
		{
		}

		public static bool IsEnableLimitedEntries()
		{
			return false;
		}

		public static bool IsEnableDifficultyEntry()
		{
			return false;
		}

		public static int GetMaxDailyEntry()
		{
			return 0;
		}

		public static int GetMaxFreeEntriesPerDay()
		{
			return 0;
		}

		public static int GetCurrentEntryCount(MainCharacterData mainCharacterData)
		{
			return 0;
		}

		private static int GetConfigEntryCost(int entryCount)
		{
			return 0;
		}

		public static bool GetCurrentEntryCost(MainCharacterData mainCharacterData, out int cost)
		{
			cost = default(int);
			return false;
		}

		public static int GetCurrentDailyEntryRemaining()
		{
			return 0;
		}

		public static int GetFreeEntryRemaining()
		{
			return 0;
		}

		public static bool IsOutOfEntryToday(MainCharacterData mainCharacterData)
		{
			return false;
		}

		public static bool IsValidEntry(RaidDifficulty difficulty)
		{
			return false;
		}

		public static int GetMaxEntryCount(RaidDifficulty difficulty)
		{
			return 0;
		}

		public static BaseKeyData CreateDefaultEntryData(RaidDifficulty difficulty)
		{
			return null;
		}

		public static BaseKeyData CreateDefaultDailyEntryData()
		{
			return null;
		}

		public static void ValidateRaidEntry(MainCharacterData characterData)
		{
		}
	}
}
