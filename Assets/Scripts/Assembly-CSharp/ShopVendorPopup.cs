using SSAR.Shop.View;
using UnityEngine;

public class ShopVendorPopup : BasePopup
{
	public GameObject resourceContainer;

	public ShopVendorTabView[] ShopVendorTabViews;

	public VendorContainer VendorContainer;

	public FlashSaleEventPopup flashSaleContainer;

	private ShopVendorTabType curTab;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	public void Show(ShopVendorTabType shopVendorTabType)
	{
	}

	public void UpdateShopVendorData()
	{
	}

	private void InitResources()
	{
	}

	private void InitTab()
	{
	}

	private void OnChangeTab(ShopVendorTabType tabType)
	{
	}

	private void ShowTab(ShopVendorTabType tabType)
	{
	}
}
