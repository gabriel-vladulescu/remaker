using System;
using System.Collections.Generic;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class ShowShopTreasureChestFxParameter
	{
		public ShopTreasureProductInfo ProductInfo { get; set; }

		public List<ItemInfo> ItemInfos { get; set; }

		public Action OnFinish { get; set; }

		public bool DisableWhenFinish { get; set; }

		public ShowShopTreasureChestFxParameter(List<ItemInfo> itemInfos, Action onFinish, bool disableWhenFinish)
		{
		}

		public ShowShopTreasureChestFxParameter(ShopTreasureProductInfo productInfo, List<ItemInfo> itemInfos, Action onFinish, bool disableWhenFinish)
		{
		}
	}
}
