using System;
using System.Collections.Generic;
using Scripts.Config;

namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	public static class FirstAnniversaryEventUtilities
	{
		public static int MaxQuestCount()
		{
			return 0;
		}

		public static FirstAnniversaryEventConfig Config()
		{
			return null;
		}

		public static string GetQuestDesc(QuestInfo questInfo)
		{
			return null;
		}

		public static bool CanClaim(MainCharacterData mainCharacterData, FirstAnniversaryQuestProgress progress)
		{
			return false;
		}

		public static bool HasClaimed(FirstAnniversaryQuestProgress progress)
		{
			return false;
		}

		public static bool HasFinishedAllQuest(MainCharacterData mainCharacterData, FirstAnniversaryQuestData data)
		{
			return false;
		}

		public static FirstAnniversaryLoginData GetLoginData()
		{
			return null;
		}

		public static int DayFromTimeGenerateLoginData(int timeGenerate)
		{
			return 0;
		}

		public static DateTime GetLoginEndTime()
		{
			return default(DateTime);
		}

		public static DateTime GetQuestEndTime()
		{
			return default(DateTime);
		}

		public static TimeSpan GetLoginRemainTime()
		{
			return default(TimeSpan);
		}

		public static bool IsLoginClaimable()
		{
			return false;
		}

		public static bool IsLoginOver()
		{
			return false;
		}

		public static List<QuestInfo> GenerateQuestInfos()
		{
			return null;
		}

		private static int GenerateQuestRequire(FirstAnniversaryQuestConstant constant, int id)
		{
			return 0;
		}

		private static int GenerateQuestReward(FirstAnniversaryQuestConstant constant, int id)
		{
			return 0;
		}

		public static bool IsEnableQuestEvent()
		{
			return false;
		}

		public static bool IsEnableLoginEvent()
		{
			return false;
		}
	}
}
