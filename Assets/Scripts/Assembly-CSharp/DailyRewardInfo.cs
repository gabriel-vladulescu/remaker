using CodeStage.AntiCheat.ObscuredTypes;

public class DailyRewardInfo
{
	private ObscuredInt mQuantity;

	public int watchCount { get; set; }

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
