using System.Collections.Generic;

namespace Scripts.Config
{
	public class DoubleExpPackageProductInfo : IProductInfo
	{
		public override int productId { get; set; }

		public override double price { get; set; }

		public override string currency { get; set; }

		public override string icon { get; set; }

		public override int sale { get; set; }

		public override bool enable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override string sku { get; set; }

		public override string name { get; set; }

		public int duration { get; set; }

		public int crystal { get; set; }

		public int soul { get; set; }

		public int expTicket { get; set; }

		public string goodName { get; set; }

		public List<ItemInfo> GetReward()
		{
			return null;
		}
	}
}
