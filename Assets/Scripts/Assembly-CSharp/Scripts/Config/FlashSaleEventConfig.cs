using System.Collections.Generic;

namespace Scripts.Config
{
	public class FlashSaleEventConfig : IConfig
	{
		public Dictionary<string, FlashSaleTimeInfo> info;

		public Dictionary<string, FlashSaleConditionInfo> conditions;

		public Dictionary<string, FlashSaleItemInfo> items;

		public void OnMapValue(string content)
		{
		}

		public void Validate()
		{
		}

		public List<FlashSaleConditionInfo> GetRateUpConditionInfos()
		{
			return null;
		}

		public List<string> GetAllSkus()
		{
			return null;
		}

		public bool FindItem(string sku, ref FlashSaleItemInfo itemInfo)
		{
			return false;
		}

		public FlashSaleTimeInfo GetFlashSaleTimeInfo()
		{
			return null;
		}

		public List<FlashSaleItemInfo> GetAllItemInfos()
		{
			return null;
		}

		private int Comparer(FlashSaleItemInfo a, FlashSaleItemInfo b)
		{
			return 0;
		}
	}
}
