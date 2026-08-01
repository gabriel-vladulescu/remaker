using Ssar.Rune.Model;

namespace SSAR.Entry.Model
{
	public class ReforeRandomSeedkey : IGetRandomSeedKey
	{
		private readonly int equipmentCollectId;

		private readonly RuneType runeType;

		public ReforeRandomSeedkey(int equipmentCollectId, RuneType runeType)
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
