using SSAR.Equipment.Enum;

namespace Assets.Scripts.Ssar.Equipment
{
	public class DefaultRarityDropConfig : RarityDropConfig
	{
		private Rarity rarity;

		private float dropRate;

		public DefaultRarityDropConfig(Rarity rarity, float dropRate)
		{
		}

		public Rarity Rarity()
		{
			return default(Rarity);
		}

		public float DropRate()
		{
			return 0f;
		}
	}
}
