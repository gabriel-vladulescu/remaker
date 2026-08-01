using System.Collections.Generic;
using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class AncientEquipmentConfig : JsonEquipmentDropConfig
	{
		public Dictionary<string, MainStats> ancientMainStats;

		public Dictionary<string, AncientActiveSkillStat> activeSkillStats;

		public Dictionary<string, AncientActiveSkill> activeSkills;

		public Dictionary<string, SkillExtraStatConfig> statConfig;

		public override void OnMapValue(string content)
		{
		}

		public bool FindAncientMainStats(EquipmentTier grade, Rarity rarity, ref MainStats mainStats)
		{
			return false;
		}

		public bool FindAncientActiveSkill(Rarity rarity, int grade, ref AncientActiveSkill ancientActiveSkill)
		{
			return false;
		}

		public AncientActiveSkillStat GetAncientActiveSkillStat(string configId, int level)
		{
			return null;
		}

		public AncientActiveSkillStat GetAncientActiveSkillStat(string key)
		{
			return null;
		}

		public bool IsActiveSkill(string fullSkillId)
		{
			return false;
		}

		public SkillExtraStatConfig GetExtraStatConfig(SkillExtraStatType type)
		{
			return null;
		}
	}
}
