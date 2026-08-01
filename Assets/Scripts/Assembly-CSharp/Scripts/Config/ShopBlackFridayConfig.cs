using System;
using System.Collections.Generic;
using Ssar.Event;

namespace Scripts.Config
{
	public class ShopBlackFridayConfig : IConfig
	{
		public Dictionary<string, EventTimeInfo> time;

		public Dictionary<string, ShopBlackFridayItemProductInfo> items;

		private List<ShopBlackFridayItemProductInfo> itemsCache;

		public void OnMapValue(string content)
		{
		}

		public List<string> GetAllSkus()
		{
			return null;
		}

		public EventTimeInfo GetTimeInfo()
		{
			return null;
		}

		public static DateTime GetEventStartTime()
		{
			return default(DateTime);
		}

		public static DateTime GetEventEndTime()
		{
			return default(DateTime);
		}

		public List<ShopBlackFridayItemProductInfo> GetListShopBlackFridayProductInfos()
		{
			return null;
		}

		public ShopBlackFridayItemProductInfo GetItemProductInfo(int productId)
		{
			return null;
		}

		public void RefreshRandomPet()
		{
		}

		public bool FindItem(string sku, ref ShopBlackFridayItemProductInfo itemInfo)
		{
			return false;
		}
	}
}
