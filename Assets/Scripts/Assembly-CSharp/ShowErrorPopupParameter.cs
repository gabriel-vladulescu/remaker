using System;

public class ShowErrorPopupParameter
{
	public string content;

	public string btnText;

	public Action onClick;

	public bool hidePopupAfterClick;

	public ShowErrorPopupParameter(string content, string btnText, Action onClick = null, bool hidePopupAfterClick = true)
	{
	}
}
