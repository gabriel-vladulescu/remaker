using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class BonusStatValue
	{
		public int id;

		public string rarity;

		public string statsType;

		public double[] value;

		public StatType StatType => default(StatType);

		public Rarity Rarity => default(Rarity);
	}
}
