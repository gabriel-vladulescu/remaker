using System.Collections.Generic;
using Ssar.Event;

namespace Scripts.Config
{
	public class EventShopConfig : IConfig
	{
		public Dictionary<string, EventTimeInfo> time;

		public Dictionary<string, EventShopTokenProductInfo> shopToken;

		private List<string> allSkus;

		private List<EventShopTokenProductInfo> tokenProducts;

		public void OnMapValue(string content)
		{
		}

		private void Cache<T>(ref List<T> list, Dictionary<string, T> dict) where T : IProductInfo
		{
		}

		private int ComparerProduct(IProductInfo a, IProductInfo b)
		{
			return 0;
		}

		public EventTimeInfo GetTimeInfo()
		{
			return null;
		}

		public List<string> GetAllSkus()
		{
			return null;
		}

		public List<EventShopTokenProductInfo> GetListShopTokenProductInfos()
		{
			return null;
		}

		public bool FindTokenProductById(int productId, ref EventShopTokenProductInfo productInfo)
		{
			return false;
		}

		public bool FindTokenProductBySku(string sku, ref EventShopTokenProductInfo productInfo)
		{
			return false;
		}
	}
}
