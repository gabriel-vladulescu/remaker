using System;
using SSAR.Equipment.Enum;

[Serializable]
public class MemoryShardCollectData : ICollectData
{
	public int collectID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

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

	public int mirrorId { get; set; }

	public int shardId { get; set; }

	public MemoryShardCollectData(int mirrorId, int shardId)
	{
	}

	public MemoryShardCollectData()
	{
	}
}
