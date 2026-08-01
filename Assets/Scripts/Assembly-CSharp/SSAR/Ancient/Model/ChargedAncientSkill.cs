using SSAR.Equipment.Enum;

namespace Ssar.Ancient.Model
{
	public class ChargedAncientSkill : AncientSkill
	{
		private int usedCharge;

		private int exp;

		private Rarity rarity;

		public int UsedCharge => 0;

		public int Exp => 0;

		public Rarity Rarity => default(Rarity);

		public ChargedAncientSkill(int id, int level)
		{
		}

		public ChargedAncientSkill(int id, int level, int usedCharge, int exp, Rarity rarity)
		{
		}
	}
}
