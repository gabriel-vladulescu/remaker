using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class ShareStatQuantity
	{
		public int id;

		public string rarity;

		public int[] quantity;

		public Rarity Rarity => default(Rarity);
	}
}
