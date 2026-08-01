using SSAR.Shop.Enum;
using SSAR.Shop.View;
using Scripts.Config;

public class ShopTreasureCosmeticContainer : ShopTreasureWeaponContainer
{
	private ShopTreasureSubTabType subTab;

	public void SelectSubTab(ShopTreasureSubTabType subTabType)
	{
	}

	protected override ShopTreastureType Category()
	{
		return default(ShopTreastureType);
	}

	protected override bool ValidateProduct(ShopTreasureProductInfo productInfo)
	{
		return false;
	}
}
