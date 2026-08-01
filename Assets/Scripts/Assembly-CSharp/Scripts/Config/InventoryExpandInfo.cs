using CodeStage.AntiCheat.ObscuredTypes;

namespace Scripts.Config
{
	public class InventoryExpandInfo
	{
		private ObscuredInt maxLevel;

		private ObscuredInt slotIncrease;

		private ObscuredInt mCrystalPerLevel;

		public int defaultNumOfSlot { get; set; }

		public int slotIncreasePerLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int maxExpandLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int crystalPerLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}
}
