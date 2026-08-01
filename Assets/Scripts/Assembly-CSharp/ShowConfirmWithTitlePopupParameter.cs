using System;
using UnityEngine;

public class ShowConfirmWithTitlePopupParameter
{
	public string content;

	public string btnLeftText;

	public string btnRightText;

	public string title;

	public Action<GameObject> BtnLeftAction;

	public Action<GameObject> BtnRightAction;

	public UISfx leftButtonSfx;

	public UISfx rightButtonSFX;

	public ShowConfirmWithTitlePopupParameter(string title, string content, string btnLefttext, string btnRightText, Action<GameObject> btnLeftAction = null, Action<GameObject> btnRightAction = null)
	{
	}
}
