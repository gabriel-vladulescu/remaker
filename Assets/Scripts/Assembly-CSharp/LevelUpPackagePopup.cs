using Assets.Scripts.Ssar.Shop.Model;
using SSAR.Shop.View;
using UnityEngine;

public class LevelUpPackagePopup : BasePopup
{
	public GameObject btn_close;

	public UILabel lb_title;

	public UILabel lb_sale;

	public UITable table;

	public GameObject wg_sale;

	public GameObject btn_skip;

	public GameObject wg_activeSkip;

	private LevelUpPackageRowView[] rowViews;

	private IShowLevelUpPackagePopupParameter parameter;

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

	public void Show(IShowLevelUpPackagePopupParameter parameter)
	{
	}

	public void UpdateData()
	{
	}

	private void UpdateRow()
	{
	}
}
