using System.Collections.Generic;
using SSAR.Equipment.Model;

namespace Assets.Scripts.Ssar.Equipment
{
	public class DropSampling
	{
		public class Report
		{
			private int dropCount;

			private GradeReport gradeReport;

			private RarityReport rarityReport;

			private SkillIdReport skillIdReport;

			private SkillLevelReport skillLevelReport;

			private BonusStatReport bonusStatReport;

			private EquipmentHasSkillReport equipmentHasSkillReport;

			private BonusStatTypesReport bonusStatTypesReport;

			public void Record(bool dropped, EquipmentConfigId equipmentConfigId)
			{
			}

			public void Show()
			{
			}
		}

		private class GradeReport
		{
			private Dictionary<string, int> countByGrade;

			public void Record(EquipmentConfigId eci)
			{
			}

			public string Show()
			{
				return null;
			}
		}

		private class RarityReport
		{
			private Dictionary<string, int> countByRarity;

			public void Record(EquipmentConfigId eci)
			{
			}

			public string Show()
			{
				return null;
			}
		}

		private class SkillIdReport
		{
			private Dictionary<string, int> countBySkillId;

			public void Record(EquipmentConfigId eci)
			{
			}

			public string Show()
			{
				return null;
			}
		}

		private class SkillLevelReport
		{
			private Dictionary<string, Dictionary<string, int>> report;

			private Dictionary<string, int> countBySkillId;

			public void Record(EquipmentConfigId eci)
			{
			}

			public string Show()
			{
				return null;
			}
		}

		private class BonusStatReport
		{
			private Dictionary<string, int> countByStatType;

			public void Record(EquipmentConfigId eci)
			{
			}

			public string Show()
			{
				return null;
			}
		}

		private class EquipmentHasSkillReport
		{
			private Dictionary<string, int> countByRarity;

			public void Record(EquipmentConfigId eci)
			{
			}

			public string Show()
			{
				return null;
			}
		}

		private class BonusStatTypesReport
		{
			private List<EquipmentStat[]> bonusStatsList;

			public void Record(EquipmentConfigId eci)
			{
			}

			public string Show()
			{
				return null;
			}
		}

		private int count;

		private readonly GradeDropConfig[] grades;

		private readonly RarityDropConfig[] rarities;

		private readonly TypeDropConfig[] types;

		private EquipmentDropLogic equipmentDropLogic;

		private string visualCategory;

		private Report report;

		public DropSampling(int count, GradeDropConfig[] grades, RarityDropConfig[] rarities, TypeDropConfig[] types, string visualCategory, EquipmentDropLogic equipmentDropLogic)
		{
		}

		public void DoSample()
		{
		}

		public void ShowReportToConsole()
		{
		}
	}
}
