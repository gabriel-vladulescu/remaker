using SSAR.Equipment.View;

namespace Scripts.Ssar.Pet
{
	public class GetPetRule : IGetCollectDataRule
	{
		private readonly PetListTabType _petListTabType;

		public GetPetRule(PetListTabType petListTabType)
		{
		}

		public bool IsSuitableConditions(ICollectData collectData)
		{
			return false;
		}
	}
}
