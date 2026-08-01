using UnityEngine;

public class ErrorPopup : BasePopup
{
	public UILabel lb_content;

	public UILabel lb_button;

	public GameObject btn_click;

	private ShowErrorPopupParameter parameter;

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

	public void Show(ShowErrorPopupParameter parameter)
	{
	}

	private void CLickButton(GameObject o)
	{
	}
}
