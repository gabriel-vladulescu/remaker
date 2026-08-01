using System;
using SSAR.BattleSystem.System.Arena.Api;

namespace Ssar.RaidBoss.API
{
	public class GetLeaderboard
	{
		private HttpEndPoints endPoints;

		private int di;

		private Action<bool, StatusCode, string, GetLeaderboardResponse> callback;

		public GetLeaderboard(HttpEndPoints endPoints, int di)
		{
		}

		public void Get(Action<bool, StatusCode, string, GetLeaderboardResponse> callback)
		{
		}

		private void failedCallback(StatusCode statusCode, string message)
		{
		}

		private void successCallback(StatusCode statusCode, string message, ResponseFromServer response)
		{
		}
	}
}
