namespace Scripts.Ssar.Arena.Eligible
{
	public class CrystalValue : IEligibleValue
	{
		private MainCharacterData mainCharacterData;

		public CrystalValue(MainCharacterData mainCharacterData)
		{
		}

		public int Value()
		{
			return 0;
		}

		private bool IsHackCrystal()
		{
			return false;
		}
	}
}
