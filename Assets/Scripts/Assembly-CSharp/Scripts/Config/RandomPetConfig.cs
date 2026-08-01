using System.Collections.Generic;
using Scripts.Ssar.Pet;

namespace Scripts.Config
{
	public class RandomPetConfig : IConfig
	{
		public Dictionary<string, RandomPet> pets;

		public void OnMapValue(string content)
		{
		}

		public RandomPet GetRandomPet(int randomPetId)
		{
			return null;
		}
	}
}
