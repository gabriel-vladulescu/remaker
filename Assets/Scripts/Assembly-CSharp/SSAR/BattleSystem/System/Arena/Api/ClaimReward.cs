using System;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class ClaimReward
	{
		private HttpEndPoints endPoints;

		private string userId;

		public ClaimReward(HttpEndPoints endPoints, string userId)
		{
		}

		public void Claim(Action<bool, StatusCode, string, ClaimRewardResult> callback)
		{
		}
	}
}
