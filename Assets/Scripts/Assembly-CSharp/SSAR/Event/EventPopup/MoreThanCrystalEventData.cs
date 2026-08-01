using System;
using System.Collections.Generic;

namespace Ssar.Event.EventPopup
{
	[Serializable]
	public class MoreThanCrystalEventData : IEventData
	{
		public int lastTime;

		public int dailyCount;

		public int totalCrystalSpent;

		public Dictionary<string, int> rewardClaimed;

		public int GetTotalExchangeTime()
		{
			return 0;
		}

		public int GetTotalExchangeValue()
		{
			return 0;
		}

		public int TotalSpent()
		{
			return 0;
		}

		public bool CanClaimReward(int productId, int max)
		{
			return false;
		}

		public bool IsReachValue(int max)
		{
			return false;
		}

		public bool IsRewardClaimed(int productId)
		{
			return false;
		}

		public void ClaimReward(int productId, int value)
		{
		}

		public void SpendCrystals(int amount)
		{
		}
	}
}
