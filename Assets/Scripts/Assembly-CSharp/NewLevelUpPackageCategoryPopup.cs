using System.Collections.Generic;
using SSAR.Shop.View;
using Scripts.Config;
using UnityEngine;

public class NewLevelUpPackageCategoryPopup : BasePopup
{
	public GameObject btn_close;

	public UITable table;

	private List<NewLevelUpPackageCategoryPopupItemView> itemViews;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	public void Show(List<NewLevelUpPackageProductInfo> productInfos)
	{
	}

	private void InitItem()
	{
	}
}
