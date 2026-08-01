using Assets.Scripts.Ssar.Equipment;
using SSAR.Equipment.Model;
using Ssar.Reforge.Model;
using Ssar.Reforge.View;
using Ssar.Rune.Model;

namespace Ssar.Reforge
{
	public static class ReforgeUtils
	{
		public static bool IsActiveSkillMaxLevel(EquipmentSkillInfo activeSkill)
		{
			return false;
		}

		public static ReforgeSkillComparerResult CompareReforgedSkill(EquipmentCollectData a, EquipmentCollectData b)
		{
			return null;
		}

		private static ShowDiffSkillParameter[] GenerateShowDiffSkillParameters(EquipmentCollectData equipmentCollectData)
		{
			return null;
		}

		public static int GetReforgePrice(EquipmentCollectData equipment, RuneType runeType)
		{
			return 0;
		}

		public static void DipslayCurrentStats(ReforgeStatRowView[] statRowViews, EquipmentCollectData equipment)
		{
		}

		public static void DisplayCurrentSocket(ReforgeStatRowView[] statRowViews, EquipmentCollectData equipment)
		{
		}

		public static void DisplayCurrentTier(ReforgeStatRowView[] statRowViews, EquipmentCollectData equipment)
		{
		}

		public static void DipslayCurrentSkill(ReforgeStatRowView[] statRowViews, EquipmentCollectData equipment)
		{
		}

		public static void DisplaySocketPredition(ReforgeStatRowView[] statRowViews, EquipmentCollectData equipment, EquipmentDropConfig equipmentDropConfig)
		{
		}

		public static void DisplayTierPredition(ReforgeStatRowView[] statRowViews, EquipmentCollectData equipment, EquipmentDropConfig equipmentDropConfig)
		{
		}

		public static void DipslaySkillPredition(ReforgeStatRowView[] statRowViews, EquipmentCollectData equipment)
		{
		}

		public static void DipslaySkillLevelPredition(ReforgeStatRowView[] statRowViews, EquipmentCollectData equipment)
		{
		}

		public static void DipslayStatsPredition(ReforgeStatRowView[] statRowViews, EquipmentCollectData equipment, EquipmentDropConfig equipmentDropConfig)
		{
		}

		public static void DipslayStatValuesPredition(ReforgeStatRowView[] statRowViews, EquipmentCollectData equipment, EquipmentDropConfig equipmentDropConfig)
		{
		}

		private static EquipmentCollectData CloneEquipment(EquipmentCollectData equipmentCollectData)
		{
			return null;
		}
	}
}
