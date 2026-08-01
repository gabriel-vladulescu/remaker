namespace Assets.Scripts.Ssar.Equipment
{
	public interface SkillLevelsBySkillNameConfig
	{
		string Name();

		SkillLevelRateConfig[] SkillLevelRateConfigs();
	}
}
