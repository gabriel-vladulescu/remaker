using System;
using System.Collections.Generic;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using Scripts.Config;

public class CosmeticGalleryPopupDataManager
{
	private class SeletItemData
	{
	}

	private Dictionary<string, bool> visualEnableData;

	private Action onChangeEquipment;

	private Dictionary<EquipmentType, EquipmentVisualAvailableInfo> dict;

	private Dictionary<CosmeticGalleryItemType, int> selectedItemHashId;

	public void ListenOnChangeCosmetic(Action action)
	{
	}

	public void UnListenOnChangeCosmetic(Action action)
	{
	}

	public void EquipCosmetic(ICosmeticGalleryItemData info)
	{
	}

	public bool IsSelect(ICosmeticGalleryItemData info)
	{
		return false;
	}

	public EquipmentVisualAvailableInfo GetEquipmentInfo(EquipmentType equipmentType)
	{
		return null;
	}

	public void SetEnableVisual(EquipmentType equipmentType, bool isEnable)
	{
	}

	public bool IsEnableVisual(EquipmentType equipmentType)
	{
		return false;
	}

	public void ResetEquipment()
	{
	}

	private void ResetDictSelected()
	{
	}
}
