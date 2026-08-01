using System;

namespace Ssar.Event.Xmas
{
	[Serializable]
	public class XmasLoginData
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
