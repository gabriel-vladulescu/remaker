using SSAR.Equipment.Enum;
using Scripts.Ssar.Pet;

namespace Scripts.Config
{
	public class ShareStatValue
	{
		public int id;

		public string rarity;

		public string shareStatsType;

		public double[] value;

		public ShareStatType ShareStatType => default(ShareStatType);

		public Rarity Rarity => default(Rarity);
	}
}
