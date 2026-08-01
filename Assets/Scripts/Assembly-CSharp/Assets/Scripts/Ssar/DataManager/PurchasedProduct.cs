using System;

namespace Assets.Scripts.Ssar.DataManager
{
	[Serializable]
	public class PurchasedProduct
	{
		public string sku;

		public string receipt;

		public PurchasedProduct()
		{
		}

		public PurchasedProduct(string sku, string receipt)
		{
		}

		public string ShowSku()
		{
			return null;
		}

		public string ShowReceipt()
		{
			return null;
		}
	}
}
