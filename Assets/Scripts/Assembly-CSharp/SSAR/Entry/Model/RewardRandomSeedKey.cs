namespace SSAR.Entry.Model
{
	public class RewardRandomSeedKey : IGetRandomSeedKey
	{
		private int id;

		public RewardRandomSeedKey(int id)
		{
		}

		public string GetKey()
		{
			return null;
		}

		public int RandomSeedInitBonusValue()
		{
			return 0;
		}
	}
}
