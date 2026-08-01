using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;
using Newtonsoft.Json;

[Serializable]
public class BloodyTowerProgressData
{
	public List<BloodyTowerFloorData> bloodyTowerFloorDatas;

	public bool hasUnlock;

	public bool hasNotifyUnlock;

	[JsonProperty]
	[JsonInclude]
	private ObscuredInt entryCount;

	[JsonInclude]
	[JsonProperty]
	private ObscuredInt lastTimePlay;

	[@JsonIgnore]
	public int EntryCount => 0;

	[@JsonIgnore]
	public int LastTimePlay => 0;

	public void ValidateWithConfig(int highestFloor)
	{
	}

	public void ClearFloor(int floor, int star, ref BloodyTowerFloorData nextFloorUnlock)
	{
	}

	public bool GetBloodyTowerFloorData(int floor, ref BloodyTowerFloorData bloodyTowerFloorData)
	{
		return false;
	}

	public int GetHighestFloorUnlocked()
	{
		return 0;
	}

	public void UnlockAllFloor()
	{
	}

	public int GetHighestClearedFloor()
	{
		return 0;
	}

	public void ResetEntry()
	{
	}

	public void OnEnterTower()
	{
	}
}
