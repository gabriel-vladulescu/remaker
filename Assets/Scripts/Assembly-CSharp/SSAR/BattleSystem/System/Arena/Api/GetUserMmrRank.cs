using System;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class GetUserMmrRank
	{
		private HttpEndPoints endPoints;

		private string userId;

		public GetUserMmrRank(HttpEndPoints endPoints, string userId)
		{
		}

		public void Get(Action<bool, StatusCode, string, GetUserMmrRankResult> callback)
		{
		}
	}
}
