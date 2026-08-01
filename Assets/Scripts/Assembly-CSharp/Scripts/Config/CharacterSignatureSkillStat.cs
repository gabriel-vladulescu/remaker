using SSAR.SkillSystem.Enum;

namespace Scripts.Config
{
	public class CharacterSignatureSkillStat : ISkillStat
	{
		public int groupId { get; set; }

		public int subId { get; set; }

		public int skillId { get; set; }

		public string name { get; set; }

		public double cooldown { get; set; }

		public double scalePower { get; set; }

		public double skillPower { get; set; }

		public int unlockLevel { get; set; }

		public string icon { get; set; }

		public double multiplierOnVisual { get; set; }

		public string localizeName { get; set; }

		public string localizeDescription { get; set; }

		public string category { get; set; }

		public int damageType { get; set; }

		public double[] value { get; set; }

		public int order { get; set; }

		public bool IsUnlock(int characterLevel)
		{
			return false;
		}

		public SignatureSkillCategory GetSkillCategory()
		{
			return default(SignatureSkillCategory);
		}

		public double GetValue(int level)
		{
			return 0.0;
		}

		public bool IsMaxLevel(int level)
		{
			return false;
		}
	}
}
