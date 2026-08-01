using Assets.Scripts.Model;
using Scripts.Config;
using Ssar.SoulLink.Model;

namespace Ssar.SoulLink
{
	public static class SoulLinkUtils
	{
		public static SoulLinkConfig Config()
		{
			return null;
		}

		public static bool IsFeatureEnabled()
		{
			return false;
		}

		public static SoulLinkConfig.Constants GetConstants()
		{
			return null;
		}

		public static SoulLinkConfig.BonusInfo GetBonusInfo(SoulLinkConfig.BonusType bonusType)
		{
			return null;
		}

		public static SoulLinkConfig.BonusInfo GetBonusInfo(int characterId)
		{
			return null;
		}

		public static SoulLinkConfig.Milestone GetMilestone(int characterId, int power)
		{
			return null;
		}

		public static float GetDefaultBonus(SoulLinkConfig.BonusType bonusType)
		{
			return 0f;
		}

		public static int GetAwakenBonusExp(int bonusExp, EnhanceItemType enhanceItemType)
		{
			return 0;
		}

		private static bool IsValidTypeToSoulLink(EnhanceItemType enhanceItemType)
		{
			return false;
		}

		public static float GetEssenceBonus()
		{
			return 0f;
		}

		public static float GetDropRateBonus(MainCharacterData mainCharacterData = null)
		{
			return 0f;
		}

		public static double GetBonusInPercentage(SoulLinkConfig.BonusType bonusType, MainCharacterData mainCharacterData)
		{
			return 0.0;
		}

		public static SoulLinkConfig.Milestone GetNextMilestone(SoulLinkConfig.BonusType bonusType, MainCharacterData mainCharacterData)
		{
			return null;
		}

		public static SoulLinkDataManager GetDataManager(MainCharacterData mainCharacterData = null)
		{
			return null;
		}
	}
}
