using System;
using SSAR.BattleSystem.System.Arena.Api;

namespace Ssar.RaidBoss.API
{
	public class GetRanking
	{
		private HttpEndPoints endPoints;

		private readonly Season s;

		private string uid;

		private Action<bool, StatusCode, string, GetRankingResponse> callback;

		public GetRanking(HttpEndPoints endPoints, Season s, string uid)
		{
		}

		public void Get(Action<bool, StatusCode, string, GetRankingResponse> callback)
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
