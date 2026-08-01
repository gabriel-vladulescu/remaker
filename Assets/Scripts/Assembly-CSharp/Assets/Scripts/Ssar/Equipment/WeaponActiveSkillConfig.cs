namespace Assets.Scripts.Ssar.Equipment
{
	public interface WeaponActiveSkillConfig
	{
		SkillCountConfig[] SkillCountConfigs();

		SkillIdConfig[] SkillIdConfigs();

		SkillLevelsBySkillIdConfig[] SkillLevelsBySkillIdConfigs();
	}
}
