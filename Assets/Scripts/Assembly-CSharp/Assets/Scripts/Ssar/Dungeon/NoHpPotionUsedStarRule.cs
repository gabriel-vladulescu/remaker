namespace Assets.Scripts.Ssar.Dungeon
{
	public class NoHpPotionUsedStarRule : IDungeonGetStarRule
	{
		private readonly int _hpPostionUsed;

		private readonly int _hpCanUsed;

		public NoHpPotionUsedStarRule(int hpPostionUsed, int hpCanUsed)
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
