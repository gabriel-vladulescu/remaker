using Assets.Scripts.Core.Skills.Conditions;
using SSAR.SkillSystem.Utils;

namespace Scripts.Config
{
	public class CharacterActiveSkillStat : ISkillStat
	{
		public int groupId { get; set; }

		public int subId { get; set; }

		public int skillId { get; set; }

		public string name { get; set; }

		public double cooldown { get; set; }

		public int cooldownCharge { get; set; }

		public double scalePower { get; set; }

		public double[] arcaneRunes { get; set; }

		public double[] powerRunes { get; set; }

		public double[] tacticRunes { get; set; }

		public int order { get; set; }

		public string icon { get; set; }

		public int unlockLevel { get; set; }

		public string localizeName { get; set; }

		public string localizeDescription { get; set; }

		public string arcaneRuneDescription { get; set; }

		public string powerRuneDescription { get; set; }

		public string tacticRuneDescription { get; set; }

		public int damageType { get; set; }

		public double skillPower { get; set; }

		public string tacticRuneStatsType { get; set; }

		public string[] castingConditions { get; set; }

		public bool IsUnlock(int characterLevel)
		{
			return false;
		}

		public double GetValue(RuneType runeType, int runeLevel)
		{
			return 0.0;
		}

		public string GetRunDescription(RuneType runeType)
		{
			return null;
		}

		public bool IsMaxRuneLevel(RuneType runeType, int runeLevel)
		{
			return false;
		}

		public int GetRuneMaxLevel(RuneType runeType)
		{
			return 0;
		}

		public ConditionName[] CastingConditionNames()
		{
			return null;
		}
	}
}
