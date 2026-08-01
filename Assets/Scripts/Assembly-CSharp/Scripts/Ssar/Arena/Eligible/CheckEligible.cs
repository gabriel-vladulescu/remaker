using System.Collections.Generic;
using Scripts.Config;

namespace Scripts.Ssar.Arena.Eligible
{
	public class CheckEligible
	{
		private ConfigManager configManager;

		private MainCharacterData mainCharacterData;

		private double realMoneySpent;

		private List<IEligibleValue> validator;

		public CheckEligible(ConfigManager configManager, MainCharacterData mainCharacterData)
		{
		}

		private void Setup()
		{
		}

		public bool IsEligible()
		{
			return false;
		}
	}
}
