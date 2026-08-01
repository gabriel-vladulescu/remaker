using CodeStage.AntiCheat.ObscuredTypes;

namespace Scripts.Config
{
	public class EventWarReward
	{
		private ObscuredInt obscuredValue;

		private ObscuredInt obscuredQuantity;

		public int id { get; set; }

		public int token { get; set; }

		public string rewardType { get; set; }

		public int value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int quantity
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ItemType GetItemType()
		{
			return default(ItemType);
		}

		public ItemInfo ParseToItemInfo()
		{
			return null;
		}

		public static int Comparer(EventWarReward a, EventWarReward b)
		{
			return 0;
		}
	}
}
