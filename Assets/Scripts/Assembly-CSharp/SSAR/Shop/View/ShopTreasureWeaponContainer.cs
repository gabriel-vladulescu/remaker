using System.Collections.Generic;
using SSAR.Shop.Enum;
using Scripts.Config;

namespace SSAR.Shop.View
{
	public class ShopTreasureWeaponContainer : AbsShopContainer
	{
		private List<ShopTreasureProductInfo> validated;

		protected override void OnAwake()
		{
		}

		protected override void OnShow()
		{
		}

		protected override void OnHide()
		{
		}

		protected override string CardViewPath()
		{
			return null;
		}

		protected override int NumOfRowInstantiate()
		{
			return 0;
		}

		protected virtual ShopTreastureType Category()
		{
			return default(ShopTreastureType);
		}

		protected virtual bool ValidateProduct(ShopTreasureProductInfo productInfo)
		{
			return false;
		}
	}
}
