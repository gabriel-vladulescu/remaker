using System;
using SSAR.View;
using UnityEngine;

public class ConfirmWithSoulPopup : BasePopup
{
	public UILabel lb_title;

	public UILabel lb_content;

	public GameObject btn_close;

	public GameObject wg_btnSoul;

	private ButtonSellView buttonSellView;

	private Action accept;

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

	public void Show(ShowConfirmWithSoulPopupParameter parameter)
	{
	}

	private void InitSell()
	{
	}

	private void Sell()
	{
	}
}
