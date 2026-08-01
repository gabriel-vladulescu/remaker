using System.Collections.Generic;
using SSAR.Shop.View;
using Scripts.Config;
using UnityEngine;

public class BundlePackagePopup : BasePopup
{
	public GameObject btn_close;

	public GameObject btn_skip;

	public GameObject wg_activeSkip;

	public UILabel lb_title;

	public UITable table;

	public GameObject btn_next;

	public GameObject btn_previous;

	private AbsShowPackageThreeProductParameter parameter;

	private List<BundlePackagePopupItemView> itemViews;

	protected override void Awake()
	{
	}

	public void Show(AbsShowPackageThreeProductParameter parameter)
	{
	}

	private void UpdateButton()
	{
	}

	public void UpdateData()
	{
	}

	public void OnBuySuccess(BundlePackageProductInfo productInfo)
	{
	}

	private new void Hide(GameObject o)
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void ExecuteBack()
	{
	}

	private void Skip(GameObject o)
	{
	}

	private void Previous(GameObject go)
	{
	}

	private void Next(GameObject go)
	{
	}

	private void UpdateSkipIcon()
	{
	}

	private void InitItem()
	{
	}

	private void UpdateTitle(string category)
	{
	}
}
