namespace Scripts.Ssar.Arena.Eligible
{
	public class CreationTimeValue : IEligibleValue
	{
		private readonly MainCharacterData mainCharacterData;

		public CreationTimeValue(MainCharacterData mainCharacterData)
		{
		}

		public int Value()
		{
			return 0;
		}
	}
}
