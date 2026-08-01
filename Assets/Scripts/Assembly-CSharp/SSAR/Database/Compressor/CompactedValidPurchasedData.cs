using System;
using Assets.Scripts.Ssar.DataManager;

namespace Ssar.Database.Compressor
{
	[Serializable]
	public class CompactedValidPurchasedData
	{
		public string sku;

		public string id;

		public CompactedValidPurchasedData()
		{
		}

		public CompactedValidPurchasedData(PurchasedProduct product)
		{
		}
	}
}
