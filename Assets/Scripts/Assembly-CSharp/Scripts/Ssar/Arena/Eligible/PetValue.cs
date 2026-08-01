using Scripts.Config;
using Scripts.Ssar.Pet;

namespace Scripts.Ssar.Arena.Eligible
{
	public class PetValue : IEligibleValue
	{
		private MainCharacterData mainCharacterData;

		private ConfigManager configManager;

		private PetGenerationConfig petGenerationConfig;

		public PetValue(MainCharacterData mainCharacterData, ConfigManager configManager)
		{
		}

		public int Value()
		{
			return 0;
		}

		private int ValidateStat(PetConfigId petConfigId)
		{
			return 0;
		}
	}
}
