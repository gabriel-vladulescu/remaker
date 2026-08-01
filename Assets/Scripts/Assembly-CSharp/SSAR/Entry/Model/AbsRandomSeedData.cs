using System.Collections.Generic;

namespace SSAR.Entry.Model
{
	public abstract class AbsRandomSeedData<T> where T : IGetRandomSeedKey
	{
		public Dictionary<string, List<int>> randomSeeds;

		public int timeCreateCharacter;

		public void SetTimeCreateCharacter(int timeCreateCharacter)
		{
		}

		public int GetRandomSeed(T randomSeedKey)
		{
			return 0;
		}

		private void Init(T randomSeedKey)
		{
		}
	}
}
