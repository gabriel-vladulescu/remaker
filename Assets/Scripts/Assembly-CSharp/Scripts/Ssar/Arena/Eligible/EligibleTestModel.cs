using SSAR.Equipment.Enum;
using Scripts.Config;

namespace Scripts.Ssar.Arena.Eligible
{
	public class EligibleTestModel
	{
		private MainCharacterData mainCharacterData;

		private ConfigManager configManager;

		public EligibleTestModel(ConfigManager configManager)
		{
		}

		public EligibleTestModel SetInventoryExpandLevel(int inventoryExpandLevel)
		{
			return null;
		}

		public EligibleTestModel SetEquipmentEnhanceLevel(EquipmentTier tier, int enhanceLevel)
		{
			return null;
		}

		public EligibleTestModel SetEquipmentAwakenLevel(EquipmentTier tier, int awakenLevel)
		{
			return null;
		}

		public EligibleTestModel SetTotalMasteryLevel(int level)
		{
			return null;
		}

		public EligibleTestModel SetCrystal(int crystal)
		{
			return null;
		}

		private MainCharacterData GenerateMainCharacterData()
		{
			return null;
		}

		public bool IsEligible()
		{
			return false;
		}
	}
}
