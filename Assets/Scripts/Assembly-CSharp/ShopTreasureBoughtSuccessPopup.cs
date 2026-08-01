using System.Collections.Generic;
using SSAR.Shop.View;
using UnityEngine;

public class ShopTreasureBoughtSuccessPopup : BasePopup
{
	public UIPlayTween PlayTween;

	public GameObject btn_mask;

	public UITable table;

	private ShopTreasureBoughtEquipmentView[] equipmentViews;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void ExecuteBack()
	{
	}

	public void Show(List<EquipmentConfigId> listEquipment)
	{
	}
}
