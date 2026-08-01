using System;

public class ShowConfirmPopupParameter
{
	public string content;

	public string btnLeftText;

	public string btnRightText;

	public Action BtnLeftAction;

	public Action BtnRightAction;

	public UISfx clickLeftSfx;

	public UISfx clickRightSfx;

	public bool enableClose;

	public bool enableBack;

	public bool hideAfterClick;

	public ShowConfirmPopupParameter(string content, string btnLefttext, string btnRightText, Action btnLeftAction = null, Action btnRightAction = null, bool enableClose = false, bool enableBack = false)
	{
	}

	public ShowConfirmPopupParameter DisableHideAfterClick()
	{
		return null;
	}
}
