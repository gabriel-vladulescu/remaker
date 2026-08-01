using System;
using System.Collections.Generic;
using Assets.Scripts.Ssar.DataManager;

namespace Ssar.Database.Compressor
{
	[Serializable]
	public class UserPurchaseCompactedData
	{
		public List<string> transactionIds;

		public List<CompactedValidPurchasedData> purchasedProducts;

		public void SetCompactedTransactionIds(List<string> transactionIdsOfReceipts)
		{
		}

		public void SetCompactedPurchasedData(List<PurchasedProduct> validPurchasedProducts)
		{
		}

		public void Clear()
		{
		}
	}
}
