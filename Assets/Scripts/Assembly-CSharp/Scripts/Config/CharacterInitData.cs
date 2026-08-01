using CodeStage.AntiCheat.ObscuredTypes;

namespace Scripts.Config
{
	public class CharacterInitData
	{
		private ObscuredInt mSoul;

		private ObscuredInt mCrystal;

		private ObscuredInt mLevel;

		public int groupId { get; set; }

		public int id { get; set; }

		public int soul
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int crystal
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int weapon { get; set; }

		public int helmet { get; set; }

		public int chestArmor { get; set; }

		public int pant { get; set; }

		public int amulet { get; set; }

		public int ring { get; set; }

		public int skillPointBonus { get; set; }

		public int cosmeticWeapon { get; set; }

		public int cosmeticHelmet { get; set; }

		public int cosmeticChestArmor { get; set; }

		public int cosmeticWing { get; set; }

		public int level
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int[] productIdsFromShopBundle { get; set; }
	}
}
