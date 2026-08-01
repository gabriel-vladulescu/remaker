namespace Ssar.Event.DemonInvasion.Config
{
	public class DemonInvasionLoginGift
	{
		public int day { get; set; }

		public string rewardTypeFree { get; set; }

		public int configIdFree { get; set; }

		public int quantityFree { get; set; }

		public string rewardTypeDemon { get; set; }

		public int configIdDemon { get; set; }

		public int quantityDemon { get; set; }

		public ItemType GetItemType(bool demon)
		{
			return default(ItemType);
		}

		public ItemInfo ParseToItemInfo(bool demon)
		{
			return null;
		}

		public static int Comparer(DemonInvasionLoginGift a, DemonInvasionLoginGift b)
		{
			return 0;
		}
	}
}
