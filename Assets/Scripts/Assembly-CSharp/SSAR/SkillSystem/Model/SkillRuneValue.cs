using Assets.Scripts.Config.Stats;
using Scripts.Config;

namespace SSAR.SkillSystem.Model
{
	public class SkillRuneValue
	{
		private int skillId;

		private HeroConfig heroConfig;

		private SkillEquippedData characterSkillData;

		private HeroData heroData;

		private double powerRuneValue;

		private double arcaneRuneValue;

		private double tacticRuneValue;

		public SkillRuneValue(int skillId, HeroConfig heroConfig, SkillEquippedData characterSkillData, HeroData heroData)
		{
		}

		private void ProcessValues()
		{
		}

		public double Power()
		{
			return 0.0;
		}

		public double Arcane()
		{
			return 0.0;
		}

		public double Tactic()
		{
			return 0.0;
		}
	}
}
