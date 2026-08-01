namespace Scripts.Config
{
	public class SkillExtraStat
	{
		private SkillExtraStatType type;

		private double value;

		public SkillExtraStatType Type => default(SkillExtraStatType);

		public double Value => 0.0;

		public SkillExtraStat(SkillExtraStatType type, double value)
		{
		}

		public SkillExtraStat(string raw)
		{
		}
	}
}
