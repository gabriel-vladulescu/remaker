using System;
using Assets.Scripts.Ssar.BloodyTower.Enum;

[Serializable]
public class BloodyTowerFloorData
{
	public int floor;

	public FloorStatus floorStatus;

	public BloodyTowerFloorData()
	{
	}

	public BloodyTowerFloorData(int floor)
	{
	}

	public void UpdateStatus(FloorStatus f)
	{
	}

	public FloorStatus GetFloorStatus()
	{
		return default(FloorStatus);
	}
}
