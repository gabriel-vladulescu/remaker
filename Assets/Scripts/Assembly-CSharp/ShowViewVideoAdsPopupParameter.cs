using System;

public class ShowViewVideoAdsPopupParameter
{
	public int currentVod;

	public int vodRequire;

	public string desc;

	public Action cancel;

	public Action confirm;

	public ShowViewVideoAdsPopupParameter(int currentVod, int vodRequire, string desc, Action cancel, Action confirm)
	{
	}
}
