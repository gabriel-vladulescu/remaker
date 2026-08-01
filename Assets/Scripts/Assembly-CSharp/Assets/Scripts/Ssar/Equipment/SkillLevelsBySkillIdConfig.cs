namespace Assets.Scripts.Ssar.Equipment
{
	public interface SkillLevelsBySkillIdConfig
	{
		int SkillId();

		SkillLevelRateConfig[] SkillLevelRateConfigs();
	}
}
