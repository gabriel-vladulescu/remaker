namespace Assets.Scripts.Ssar.Equipment
{
	public class DefaultSkillLevelsBySkillIdConfig : SkillLevelsBySkillIdConfig
	{
		private int skillId;

		private SkillLevelRateConfig[] skillLevelRateConfigs;

		public DefaultSkillLevelsBySkillIdConfig(int skillId, SkillLevelRateConfig[] skillLevelRateConfigs)
		{
		}

		public int SkillId()
		{
			return 0;
		}

		public SkillLevelRateConfig[] SkillLevelRateConfigs()
		{
			return null;
		}
	}
}
