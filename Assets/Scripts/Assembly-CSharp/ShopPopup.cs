using SSAR.Shop.Enum;
using SSAR.Shop.View;
using UnityEngine;

public class ShopPopup : BasePopup
{
	public GameObject resourcesContainer;

	public ShopGroupView[] ShopGroupViews;

	public ShopTabView[] ShopTabViews;

	public UITable TabGrid;

	public ShopLimitedTimeContainer ShopLimitedTimeContainer;

	public ShopBeginnerContainer ShopBeginnerContainer;

	public ShopEquipmentContainer ShopEquipmentContainer;

	public ShopRuneContainer ShopRuneContainer;

	public ShopCostumeContainer ShopCostumeContainer;

	public ShopPetContainer ShopPetContainer;

	public ShopSubscriptionContainer ShopSubscriptionContainer;

	public ShopGrowthContainer ShopGrowthContainer;

	public ShopCrystalContainer ShopCrystalContainer;

	public ShopSoulContainer ShopSoulContainer;

	public ShopStaminaContainer ShopStaminaContainer;

	public ShopBoosterContainer ShopBoosterContainer;

	protected override void Awake()
	{
	}

	private void InitResources()
	{
	}

	public void Show(ShopTabType tabType)
	{
	}

	protected override void OnDisable()
	{
	}

	public override void Hide()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	private void EndTrackShopAndIapPlayResourceShop()
	{
	}

	private void InitTab()
	{
	}

	private void InitGroup()
	{
	}

	private void OnSelectGroup(ShopGroupType shopGroupType)
	{
	}

	private ShopGroupType GetGroupByTab(ShopTabType shopTabType)
	{
		return default(ShopGroupType);
	}

	private void OnSelectTab(ShopTabType shopTabType)
	{
	}
}
