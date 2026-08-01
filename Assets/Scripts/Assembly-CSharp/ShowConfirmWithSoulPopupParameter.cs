using System;

public class ShowConfirmWithSoulPopupParameter
{
	public string title;

	public string content;

	public int soul;

	public Action onAccept;

	public ShowConfirmWithSoulPopupParameter(string title, string content, int soul, Action onAccept)
	{
	}
}
