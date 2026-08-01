using System;
using Scripts.Config;
using Ssar.Event.SevenDaysCampaign.Model;

namespace Ssar.Event.SevenDaysCampaign
{
	public static class CampaignUtils
	{
		public static CampaignConfig GetConfig()
		{
			return null;
		}

		public static CampaignConfig.Constants GetConstants()
		{
			return null;
		}

		public static bool IsFeatureEnabled()
		{
			return false;
		}

		public static int GetHighestDay()
		{
			return 0;
		}

		public static int GetQuestRequirement(CampaignConfig.CampaignQuestItem questItem)
		{
			return 0;
		}

		public static bool IsMasterQuest(CampaignConfig.CampaignQuestItem questItem)
		{
			return false;
		}

		public static DateTime GetEndTime()
		{
			return default(DateTime);
		}

		public static bool IsEventEnd()
		{
			return false;
		}

		public static CampaignData GetCampaignData(MainCharacterData mainCharacterData = null)
		{
			return null;
		}

		public static int GetQuestProgress(CampaignConfig.CampaignQuestItem questItem)
		{
			return 0;
		}

		public static bool IsQuestClaimed(CampaignConfig.CampaignQuestItem questItem)
		{
			return false;
		}

		public static bool IsQuestClaimable(CampaignConfig.CampaignQuestItem questItem)
		{
			return false;
		}

		public static bool IsValidDay(int day)
		{
			return false;
		}

		private static int GetCurrentDay()
		{
			return 0;
		}

		public static bool IsCampaignClaimable()
		{
			return false;
		}

		public static bool IsDayClaimable(int day)
		{
			return false;
		}

		public static int GetMasterProgress()
		{
			return 0;
		}

		public static bool TodayHasShowPopup()
		{
			return false;
		}

		private static int GetLastTimeShowPopup()
		{
			return 0;
		}

		public static void SaveTimeShowPopup()
		{
		}
	}
}
