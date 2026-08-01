using UnityEngine;

public class ConfirmWithTitlePopup : BasePopup
{
	public UILabel lb_title;

	public UILabel lb_content;

	public UILabel lb_button_left;

	public UILabel lb_button_right;

	public GameObject btn_left;

	public GameObject btn_right;

	private ShowConfirmWithTitlePopupParameter parameter;

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

	public void Show(ShowConfirmWithTitlePopupParameter parameter)
	{
	}

	private void CLickButtonLeft(GameObject o)
	{
	}

	private void ClickButtonRight(GameObject o)
	{
	}
}
