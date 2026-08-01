namespace Assets.Scripts.Ssar.Dungeon
{
	public class ClearWithinTimeStarRule : IDungeonGetStarRule
	{
		private readonly float _timeThreshold;

		private readonly float _timeClear;

		public ClearWithinTimeStarRule(float timeThreshold, float timeClear)
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
