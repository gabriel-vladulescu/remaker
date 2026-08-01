using System.Collections.Generic;

namespace Assets.Scripts.Ssar.DailyLogin.Model
{
	public class CompactedDailyLoginData
	{
		public int claimCount;

		public int claimBonusCount;

		public Dictionary<string, int> rewards;

		public void AddReward(DailyLoginGift gift)
		{
		}

		private bool IsRandomCard(DailyLoginGift gift)
		{
			return false;
		}

		public int GetRewardQuantity(ItemType type)
		{
			return 0;
		}
	}
}
