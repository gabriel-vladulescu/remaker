namespace Assets.Scripts.Ssar.Dungeon
{
	public class CompleteAllObjectiveStarRule : IDungeonGetStarRule
	{
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
