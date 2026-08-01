using System;
using System.Collections.Generic;
using SSAR.Equipment.Enum;

[Serializable]
public class VisualId
{
	public EquipmentType EquipmentType;

	public List<int> visualIds;

	public VisualId(EquipmentType equipmentType, List<int> visualIds)
	{
	}
}
