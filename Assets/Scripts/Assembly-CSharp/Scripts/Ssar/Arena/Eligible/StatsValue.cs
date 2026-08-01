namespace Scripts.Ssar.Arena.Eligible
{
	public class StatsValue : IEligibleValue
	{
		private MainCharacterData mainCharacterData;

		private const int MAX_ATTACK = 600000;

		private const int MAX_DEF = 600000;

		private const int MAX_HP = 1000000;

		public StatsValue(MainCharacterData mainCharacterData)
		{
		}

		public int Value()
		{
			return 0;
		}

		private int GetHackValue(double currentStat, int maxStat)
		{
			return 0;
		}
	}
}
