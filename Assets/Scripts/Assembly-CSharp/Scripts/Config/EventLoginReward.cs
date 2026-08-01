using CodeStage.AntiCheat.ObscuredTypes;

namespace Scripts.Config
{
	public class EventLoginReward
	{
		private ObscuredInt obscuredValue;

		private ObscuredInt obscuredQuantity;

		public int day { get; set; }

		public string rewardType { get; set; }

		public bool highlight { get; set; }

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

		public static int Comparer(EventLoginReward a, EventLoginReward b)
		{
			return 0;
		}
	}
}
