using System;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class GetLeaderboard
	{
		private HttpEndPoints endPoints;

		private readonly Seasons[] seasons;

		public GetLeaderboard(HttpEndPoints endPoints, Seasons[] seasons)
		{
		}

		public void Get(Action<bool, StatusCode, string, GetLeaderboardResult> callback)
		{
		}
	}
}
