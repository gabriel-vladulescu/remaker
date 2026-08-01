namespace Scripts.Ssar.Arena.Eligible
{
	public class PlaytimeValue : IEligibleValue
	{
		private readonly MainCharacterData mainCharacterData;

		public PlaytimeValue(MainCharacterData mainCharacterData)
		{
		}

		public int Value()
		{
			return 0;
		}

		private bool IsHackTime()
		{
			return false;
		}
	}
}
