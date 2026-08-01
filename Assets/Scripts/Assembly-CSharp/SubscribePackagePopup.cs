using Assets.Scripts.Ssar.Shop.Command;
using Assets.Scripts.Ssar.Shop.Model;
using UnityEngine;

public class SubscribePackagePopup : BasePopup
{
	public GameObject btn_close;

	public UILabel lb_title;

	public UILabel lb_dayRemaining;

	public UITable table;

	private ISubscribePackageLogic parameter;

	private ShowSubscribePackageParameters showParamater;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	public override void Hide()
	{
	}

	public void Show(ISubscribePackageLogic parameter, ShowSubscribePackageParameters showParamater)
	{
	}

	public void UpdateData()
	{
	}

	private void UpdateRowData()
	{
	}
}
