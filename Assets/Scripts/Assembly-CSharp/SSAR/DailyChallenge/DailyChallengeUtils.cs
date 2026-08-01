using System.Collections.Generic;
using Scripts.Config;
using Ssar.DailyChallenge.Model;

namespace Ssar.DailyChallenge
{
	public static class DailyChallengeUtils
	{
		public const float DEFAULT_STAGE_ACTIVATION_DURATION = 5f;

		public const float DEFAULT_LEVEL_UP_STAGE_ACTIVATION_DURATION = 15f;

		private static Dictionary<string, BuffType> cacheBuffTypes;

		public static DailyChallengeConfig GetConfig()
		{
			return null;
		}

		public static DailyChallengeMonsterConfig GetMonsterConfig()
		{
			return null;
		}

		public static DailyChallengeRewardConfig GetRewardConfig()
		{
			return null;
		}

		public static ScenarioDifficulty GetHighestDifficulty()
		{
			return default(ScenarioDifficulty);
		}

		public static int GetPowerRecommend(ScenarioDifficulty difficulty)
		{
			return 0;
		}

		public static int GetMaxEntryPerDay()
		{
			return 0;
		}

		public static bool IsMaxEntryToday(MainCharacterData mainCharacterData)
		{
			return false;
		}

		public static int GetFreeEntriesPerDay()
		{
			return 0;
		}

		public static bool GetCurrentEntryCost(MainCharacterData mainCharacterData, out int cost)
		{
			cost = default(int);
			return false;
		}

		private static int GetConfigEntryCost(int entryCount)
		{
			return 0;
		}

		public static int GetInitCount(int groupId, int id)
		{
			return 0;
		}

		public static DailyChallengeConfig.Round GetRoundByStageOrder(int stageOrder)
		{
			return null;
		}

		public static DailyChallengeConfig.Buff GetBuff(int buffId)
		{
			return null;
		}

		public static BuffType ParseBuffType(string data, BuffType defaultValue = BuffType.ATTACK)
		{
			return default(BuffType);
		}

		public static DailyChallengeRewardConfig.Pool GetRewardPool(ScenarioDifficulty difficulty, int stageOrder)
		{
			return null;
		}

		public static ChallengeEndParameters GenerateEndParameter(ScenarioDifficulty difficulty, bool isWin = true)
		{
			return null;
		}

		public static ChallengeEndParametersWithDemonInvasion ChallengeEndParametersWithDemonInvasion(bool isWin)
		{
			return null;
		}

		private static MainCharacterData GetCharacterPreset(MainCharacterData mainCharacterData)
		{
			return null;
		}

		public static MainCharacterData GenerateCharacter(MainCharacterData mainCharacterData)
		{
			return null;
		}
	}
}
