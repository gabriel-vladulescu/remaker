using CodeStage.AntiCheat.ObscuredTypes;

public class DailyLoginGift
{
	private ObscuredInt mQuantity;

	public int day { get; set; }

	public string rewardType { get; set; }

	public int configId { get; set; }

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
}
