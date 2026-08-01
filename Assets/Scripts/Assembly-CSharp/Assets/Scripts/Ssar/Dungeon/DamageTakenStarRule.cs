namespace Assets.Scripts.Ssar.Dungeon
{
	public class DamageTakenStarRule : IDungeonGetStarRule
	{
		private readonly float _hpThreshold;

		private readonly float _hpLostPercent;

		public DamageTakenStarRule(float hpThreshold, float hpLostPercent)
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
