using UnityEngine;

public class ShowShopPurchaseConfirmPopupParameter
{
	public string title;

	public string icon;

	public int price;

	public string desc;

	public string buttonConfirmDesc;

	public Currency Currency;

	public UIWidget.AspectRatioSource AspectRatioSource;

	public int size;

	public GameObject source;

	public Color titleColor;

	public ShowShopPurchaseConfirmPopupParameter(string title, int price, Currency currency, GameObject source, string desc = "", string buttonCofirmDesc = "")
	{
	}

	public ShowShopPurchaseConfirmPopupParameter SetTitleColor(Color color)
	{
		return null;
	}
}
