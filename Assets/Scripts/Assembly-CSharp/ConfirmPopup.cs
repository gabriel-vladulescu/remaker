using UnityEngine;

public class ConfirmPopup : BasePopup
{
	public UILabel lb_content;

	public UILabel lb_button_left;

	public UILabel lb_button_right;

	public GameObject btn_left;

	public GameObject btn_right;

	public GameObject btn_close;

	private ShowConfirmPopupParameter parameter;

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

	public void Show(ShowConfirmPopupParameter parameter)
	{
	}

	private void CLickButtonLeft(GameObject o)
	{
	}

	private void ClickButtonRight(GameObject o)
	{
	}
}
