using SSAR.Shop.Enum;
using Scripts.Config;

namespace SSAR.Shop.View
{
	public class ShopTreasureRuneContainer : ShopTreasureWeaponContainer
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
}
