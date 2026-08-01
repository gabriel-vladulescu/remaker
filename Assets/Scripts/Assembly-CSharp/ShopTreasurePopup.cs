using SSAR.Shop.Enum;
using SSAR.Shop.View;
using UnityEngine;

public class ShopTreasurePopup : BasePopup
{
	public GameObject resourcesContainer;

	public ShopTreasureTabView[] TabViews;

	public ShopTreasureSubTabView[] CosmeticSubTabViews;

	public ShopTreasureSubTabView[] RuneSubTabViews;

	public ShopTreasureSubTabView[] FreeEquipmentSubTabViews;

	public ShopTreasureBannerView BannerView;

	public ShopTreasureWeaponContainer WeaponContainer;

	public ShopTreasureArmorContainer ArmorContainer;

	public ShopTreasureAccessoryContainer AccessoryContainer;

	public ShopTreasureCosmeticContainer CosmeticContainer;

	public ShopTreasureRuneContainer RuneContainer;

	public ShopTreasurePetContainer PetContainer;

	public ShopTreasureAncientContainer AncientContainer;

	public ShopTreasureFreeEquipmentContainer FreeEquipmentContainer;

	private ShopTreasureSubTabType currentFreeEquipmentSubTabType;

	protected override void Awake()
	{
	}

	public void Show(ShopTreastureType tab)
	{
	}

	protected override void OnDisable()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	private void EndTrackShopAndIapPlayCardShop()
	{
	}

	private void InitTab()
	{
	}

	private void InitResources()
	{
	}

	private void OnSelectTab(ShopTreastureType shopTabType)
	{
	}

	private void OnSelectSubTap(ShopTreasureSubTabType shopTreasureSubTabType)
	{
	}
}
