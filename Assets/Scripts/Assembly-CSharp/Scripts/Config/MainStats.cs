using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class MainStats
	{
		public int id;

		public int grade;

		public string rarity;

		public int[] value;

		public string statType;

		public Rarity Rarity => default(Rarity);

		public EquipmentTier Grade => default(EquipmentTier);

		public StatType StatType => default(StatType);
	}
}
