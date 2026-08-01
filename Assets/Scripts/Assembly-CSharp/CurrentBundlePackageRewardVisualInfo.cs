using System;
using System.Collections.Generic;
using SSAR.Equipment.Enum;

[Serializable]
public class CurrentBundlePackageRewardVisualInfo
{
	private int currentPetVisualId;

	private List<VisualId> currentEquipmentVisualInfos;

	public void SetPetVisualId(int petVisualId)
	{
	}

	public int GetPetVisualId()
	{
		return 0;
	}

	public void SetVisualId(EquipmentType equipmentType, List<int> visualId)
	{
	}

	public List<VisualId> GetListVisualIdPrefer()
	{
		return null;
	}

	public void Clear()
	{
	}
}
