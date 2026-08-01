using System.Collections.Generic;
using SSAR.Equipment.Enum;
using SSAR.Shop.Enum;
using SSAR.Shop.View;

public class PackagePlayTestData
{
	public bool IsFirstTimeBtnClicked;

	public bool IsTestBtnClicked;

	public ShopTabType ShopTapType;

	public AbsShowPackageInfoParameter PackageInfo;

	public Dictionary<EquipmentType, OneProductEquipmentData> Equipment;

	public Dictionary<EquipmentType, OneProductEquipmentData> Cosmetic;

	public OneProductPetData petConfigId;

	public PackagePlayTestData(bool firstTimeClick, bool isTestBtnClick)
	{
	}

	public void SetTestBtnClick(bool isClick)
	{
	}

	public void AddItemToEquipment(EquipmentType type, OneProductEquipmentData data)
	{
	}

	public void AddItemTocosmetic(EquipmentType type, OneProductEquipmentData data)
	{
	}

	public void SetPackageInfo(AbsShowPackageInfoParameter info)
	{
	}
}
