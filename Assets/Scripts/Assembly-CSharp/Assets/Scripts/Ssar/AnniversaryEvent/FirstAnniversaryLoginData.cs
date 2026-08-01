using System;

namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	[Serializable]
	public class FirstAnniversaryLoginData
	{
		public int timeGenerate;

		public int lastClaimDay;

		public int lastTimeClaim;

		public int activatedLv;

		public int continousDayCount;

		public void ClaimReward(int day)
		{
		}

		public bool IsClaimedReward(int day)
		{
			return false;
		}

		public bool IsClaimable(int day)
		{
			return false;
		}

		private void UpdateContinousDayCount()
		{
		}
	}
}
