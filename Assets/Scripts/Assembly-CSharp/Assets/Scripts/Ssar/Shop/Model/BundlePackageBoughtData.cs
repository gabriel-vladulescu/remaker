using System;
using System.Collections.Generic;
using LitJson;

namespace Assets.Scripts.Ssar.Shop.Model
{
	[Serializable]
	public class BundlePackageBoughtData
	{
		[JsonInclude]
		private Dictionary<string, int> bought;

		[JsonInclude]
		private Dictionary<string, int> currentBought;

		[JsonInclude]
		private int lastTimeReset;

		public int GetPurchasedCount(int productId)
		{
			return 0;
		}

		public bool HasBoughtProduct(int productId)
		{
			return false;
		}

		public void BoughtProduct(int productId)
		{
		}

		public void ResetPurchasedCount()
		{
		}

		public int GetLastResetTime()
		{
			return 0;
		}

		public void ValidatePurchaseCount()
		{
		}

		public void ValidateResetTime()
		{
		}
	}
}
