namespace Scripts.Ssar.Arena.Eligible
{
	public class DailyLoginValue : IEligibleValue
	{
		private MainCharacterData mainCharacterData;

		public DailyLoginValue(MainCharacterData mainCharacterData)
		{
		}

		public int Value()
		{
			return 0;
		}
	}
}
