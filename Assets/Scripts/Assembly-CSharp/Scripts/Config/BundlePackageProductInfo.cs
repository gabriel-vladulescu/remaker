using System;
using System.Collections.Generic;

namespace Scripts.Config
{
	public class BundlePackageProductInfo : IProductInfo
	{
		public override int productId { get; set; }

		public override double price { get; set; }

		public override string currency { get; set; }

		public override string icon { get; set; }

		public override bool enable { get; set; }

		public int buyCount { get; set; }

		public int bundleRewardId { get; set; }

		public override int sale { get; set; }

		public string mapTriggerFrom { get; set; }

		public string mapTriggerTo { get; set; }

		public override string name { get; set; }

		public string description { get; set; }

		public override string sku { get; set; }

		public string goodName { get; set; }

		public List<string> category { get; set; }

		public bool isHot { get; set; }

		public int orderInShopPack { get; set; }

		public bool appendPostfixForMetric { get; set; }

		public int height { get; set; }

		public int positionY { get; set; }

		public bool showIconInDetailPopup { get; set; }

		public int heightDetail { get; set; }

		public int positionYDetail { get; set; }

		public bool enableBuy { get; set; }

		public string startTime { get; set; }

		public string endTime { get; set; }

		public bool IsValidStartTime()
		{
			return false;
		}

		public bool IsValidEndTime()
		{
			return false;
		}

		public DateTime GetStartTime()
		{
			return default(DateTime);
		}

		public DateTime GetEndTime()
		{
			return default(DateTime);
		}
	}
}
