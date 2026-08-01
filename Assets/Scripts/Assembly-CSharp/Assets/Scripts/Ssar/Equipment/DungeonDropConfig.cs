namespace Assets.Scripts.Ssar.Equipment
{
	public interface DungeonDropConfig
	{
		int MaxDropCount();

		float DropPercentage();

		GradeDropConfig[] ShowGradesDropConfig();

		RarityDropConfig[] ShowRaritiesDropConfig();

		TypeDropConfig[] ShowTypesDropConfig();
	}
}
