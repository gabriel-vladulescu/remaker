using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class RarityDropPercentage
	{
		private string rawValue;

		private Rarity rarity;

		private float percentage;

		public string RawValue => null;

		public Rarity Rarity => default(Rarity);

		public float Percentage => 0f;

		public RarityDropPercentage(string rawValue)
		{
		}

		public RarityDropPercentage(Rarity rarity, int percentage)
		{
		}
	}
}
