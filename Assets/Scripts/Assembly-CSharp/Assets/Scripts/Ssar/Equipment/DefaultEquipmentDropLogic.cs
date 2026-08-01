using System.Collections.Generic;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using Ssar.Analytics.Metrics;

namespace Assets.Scripts.Ssar.Equipment
{
	public class DefaultEquipmentDropLogic : EquipmentDropLogic
	{
		protected EquipmentDropConfig equipmentDropConfig;

		public DefaultEquipmentDropLogic(EquipmentDropConfig equipmentDropConfig)
		{
		}

		public EquipmentConfigId Drop(CharacterId characterId, GradeDropConfig[] grades, RarityDropConfig[] rarities, TypeDropConfig[] types, string visualCategory, List<int> visualIdIgnore)
		{
			return null;
		}

		protected bool GenerateActiveSkill(CharacterId characterId, EquipmentType equipmentType, int grade, Rarity rarity, ref int[] skillIds, ref int[] skillLevels)
		{
			return false;
		}

		protected bool GenerateActiveSkill(WeaponActiveSkillConfig was, ref int skillId, ref int skillLevel)
		{
			return false;
		}

		protected bool GeneratePassiveSkill(CharacterId characterId, ref string skillName, ref int skillLevel, EquipmentType equipmentType, int grade, Rarity rarity)
		{
			return false;
		}

		protected bool GenerateAncientSkill(ref int skillId, ref int skillLevel, EquipmentType equipmentType, int grade, Rarity rarity, List<int> visualIdIgnore)
		{
			return false;
		}

		protected EquipmentStat[] GenerateBonusStats(EquipmentType type, EquipmentTier grade, Rarity rarity)
		{
			return null;
		}

		protected EquipmentStat GenerateMainStats(EquipmentType type, EquipmentTier grade, Rarity rarity)
		{
			return null;
		}

		protected EquipmentTier GenerateGrade(GradeDropConfig[] gradesDropConfig)
		{
			return default(EquipmentTier);
		}

		protected Rarity GenerateRarity(RarityDropConfig[] raritiesDropConfig)
		{
			return default(Rarity);
		}

		protected EquipmentType GenerateType(TypeDropConfig[] typesDropConfig)
		{
			return default(EquipmentType);
		}
	}
}
