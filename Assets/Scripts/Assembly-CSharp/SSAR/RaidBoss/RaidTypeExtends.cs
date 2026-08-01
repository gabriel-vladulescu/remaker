namespace Ssar.RaidBoss
{
	public static class RaidTypeExtends
	{
		public static ScenarioDifficulty ConvertToScenarioDifficulty(this RaidDifficulty tabType)
		{
			return default(ScenarioDifficulty);
		}

		public static RaidDifficulty ConvertToRaidDifficulty(this ScenarioDifficulty difficulty)
		{
			return default(RaidDifficulty);
		}
	}
}
