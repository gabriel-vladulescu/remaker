using SSAR.Equipment.Enum;

namespace Scripts.Ssar.Pet
{
	public class TierDropPercentage
	{
		private readonly EquipmentTier _tier;

		private readonly float rate;

		private readonly string rawValue;

		public string RawValue => null;

		public TierDropPercentage(string rawValue)
		{
		}

		public TierDropPercentage(EquipmentTier tier, float rate)
		{
		}

		public float Rate()
		{
			return 0f;
		}

		public EquipmentTier Tier()
		{
			return default(EquipmentTier);
		}
	}
}
