using System.Collections.Generic;
using SSAR.Shop.View;
using Scripts.Config;
using UnityEngine;

public class NewSubscribePackageCategoryPopup : BasePopup
{
	public GameObject btn_close;

	public UITable table;

	public GameObject videoTicketDescObj;

	private List<NewSubscribePackageCategoryPopupItemView> itemViews;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	public void Show(List<NewSubscribePackageProductInfo> productInfos)
	{
	}

	private void InitItem()
	{
	}
}
