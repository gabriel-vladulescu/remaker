using Assets.Scripts.Model;

namespace SSAR.Entry.Model
{
	public class SalvageItemRandomSeedKey : IGetRandomSeedKey
	{
		private readonly IItem item;

		public SalvageItemRandomSeedKey(IItem item)
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
