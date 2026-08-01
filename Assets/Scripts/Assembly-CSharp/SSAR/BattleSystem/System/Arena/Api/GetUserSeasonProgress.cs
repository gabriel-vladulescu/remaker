using System;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class GetUserSeasonProgress
	{
		private HttpEndPoints endPoints;

		private int seasonId;

		private string userId;

		public GetUserSeasonProgress(HttpEndPoints endPoints, int seasonId, string userId)
		{
		}

		public void Get(Action<bool, StatusCode, string, GetUserSeasonProgressResult> callback)
		{
		}
	}
}
