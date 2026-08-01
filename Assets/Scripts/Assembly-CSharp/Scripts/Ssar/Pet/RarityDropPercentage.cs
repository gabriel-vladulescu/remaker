using SSAR.Equipment.Enum;

namespace Scripts.Ssar.Pet
{
	public class RarityDropPercentage
	{
		private readonly Rarity rarity;

		private readonly float rate;

		private readonly string rawValue;

		public string RawValue => null;

		public RarityDropPercentage(Rarity rarity, float rate)
		{
		}

		public RarityDropPercentage(string rawValue)
		{
		}

		public float Rate()
		{
			return 0f;
		}

		public Rarity Rarity()
		{
			return default(Rarity);
		}
	}
}
