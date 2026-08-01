using System;
using System.Collections.Generic;
using SSAR.BattleSystem.System.Arena.Api;
using Scripts.Config;

namespace Scripts.Ssar.Arena
{
	public static class ArenaUtilities
	{
		private static int CYCLE;

		public static void Save(MainCharacterData mainCharacterData)
		{
		}

		public static int StaminaRequire()
		{
			return 0;
		}

		public static bool IsValidArenaKey()
		{
			return false;
		}

		public static DuelArenaData GetDuelArenaData()
		{
			return null;
		}

		public static ArenaConfig GetArenaConfig()
		{
			return null;
		}

		public static void GetArenaTierIcon(ArenaTier tier, ref UISprite sprite)
		{
		}

		public static void GetTierName(ArenaTier tier, ref UILabel label, bool updateColor)
		{
		}

		public static void UpdateTierTextColor(UILabel label, ArenaTier tier, bool updateFontSize = true)
		{
		}

		public static void UpdateDivision(UILabel label, ArenaTier arenaTier, ArenaDivision division, int rank, ref UISprite sprite)
		{
		}

		public static string GetTierName(ArenaTier tier)
		{
			return null;
		}

		public static CharacterId GetCharacterId(MainCharacterData mainCharacterData)
		{
			return null;
		}

		public static HttpEndPoints GetHttpEndPoints()
		{
			return null;
		}

		public static bool IsEligible(MainCharacterData mainCharacterData, ConfigManager configManager)
		{
			return false;
		}

		public static ArenaTier ParseTier(TierName tierName)
		{
			return default(ArenaTier);
		}

		public static void ParseFromRawStars(long rawStars, out ArenaTier tier, out ArenaDivision division, out int star)
		{
			tier = default(ArenaTier);
			division = default(ArenaDivision);
			star = default(int);
		}

		public static void ParseFromRawStars(UserSeasonProgress userSeasonProgress, out ArenaTier tier, out ArenaDivision division)
		{
			tier = default(ArenaTier);
			division = default(ArenaDivision);
		}

		public static string GetArenaErrorMessage(StatusCode statusCode, string message)
		{
			return null;
		}

		public static int LevelRequireToUnlock()
		{
			return 0;
		}

		public static List<SeasonalRankRewardValue> GetLeagueRewardInfos(ArenaTier league, int seasonCode)
		{
			return null;
		}

		public static List<PromotionRankRewardValue> GetArenaPromotionRewardInfos(ArenaTier league)
		{
			return null;
		}

		public static PromotionRankRewardValue GetArenaPromotionRewardInfos(int rankID)
		{
			return null;
		}

		public static RankData ParseToRankData(UserSeasonProgress userSeasonProgress, int rank)
		{
			return null;
		}

		public static void GetUserCurrentSeasonMMRRank(UserSeasonProgress userSeasonProgress, Action<int> rank)
		{
		}

		public static string GetCurrentSeasonName(int seasonCount)
		{
			return null;
		}

		public static string GetPreviousSeasonName(int seasonCount)
		{
			return null;
		}

		public static string ToRoman(int number)
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

		public static int ConvertToRankID(RankData data)
		{
			return 0;
		}
	}
}
