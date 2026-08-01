namespace Assets.Scripts.Ssar.Dungeon
{
	public class NoUesdSkillStar : IDungeonGetStarRule
	{
		private readonly bool usedSkill;

		public NoUesdSkillStar(bool used)
		{
		}

		public bool IsComplete()
		{
			return false;
		}

		public string Description()
		{
			return null;
		}

		public int Priority()
		{
			return 0;
		}
	}
}
