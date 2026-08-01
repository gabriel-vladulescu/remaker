using System;
using SSAR.Equipment.Enum;

[Serializable]
public class BoostItemCollectData : ICollectData
{
	public int collectID { get; set; }

	public CollectType collectType
	{
		get
		{
			return default(CollectType);
		}
		set
		{
		}
	}

	public BoostItemType BoostItemType { get; set; }

	public int quantity { get; set; }

	public BoostItemCollectData()
	{
	}

	public BoostItemCollectData(BoostItemType type, int quantity)
	{
	}

	public void Consume()
	{
	}

	public void AddQuantity(int quantity)
	{
	}
}
