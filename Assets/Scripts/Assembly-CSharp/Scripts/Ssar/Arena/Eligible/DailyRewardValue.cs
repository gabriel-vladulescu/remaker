namespace Scripts.Ssar.Arena.Eligible
{
	public class DailyRewardValue : IEligibleValue
	{
		private const int CRYSTAL_TRHESHOLD = 3000;

		private const int SOUL_TRHESHOLD = 2000000;

		private const int HACK_VALUE = 1000000;

		private MainCharacterData mainCharacterData;

		public DailyRewardValue(MainCharacterData mainCharacterData)
		{
		}

		public int Value()
		{
			return 0;
		}
	}
}
