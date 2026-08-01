using Scripts.Ssar.Pet;

namespace SSAR.Shop.View
{
	public class OneProductPetData
	{
		public PetConfigId PetConfigId { get; private set; }

		public RandomPet RandomPet { get; private set; }

		public OneProductPetData(PetConfigId PetConfigId, RandomPet randomPet)
		{
		}
	}
}
