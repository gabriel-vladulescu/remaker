using System;
using SSAR.Shop.View;
using UnityEngine;

public class ShopBlackFridaySalePopup : BasePopup
{
	public GameObject btn_close;

	public ShopBlackFridaySaleTabView[] ShopBlackFridaySaleTabViews;

	public BlackFridayItemsContainer blackFridayItemsContainer;

	public BlackFridayPackagesContainer blackFridayPackagesContainer;

	private ShopBlackFridaySaleTabType curTab;

	private Action onClose;

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

	public void Show(ShopBlackFridaySaleTabType shopBlackFridaySaleTabType, Action onClose)
	{
	}

	public void Show(ShopBlackFridaySaleTabType shopBlackFridaySaleTabType)
	{
	}

	public void UpdateShopItemsData()
	{
	}

	public void UpdateShopPacksData()
	{
	}

	private void InitTab()
	{
	}

	private void OnChangeTab(ShopBlackFridaySaleTabType tabType)
	{
	}

	private void ShowTab(ShopBlackFridaySaleTabType tabType)
	{
	}
}
