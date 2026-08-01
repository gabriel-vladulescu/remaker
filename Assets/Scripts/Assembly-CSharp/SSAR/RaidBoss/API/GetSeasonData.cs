using System;
using SSAR.BattleSystem.System.Arena.Api;

namespace Ssar.RaidBoss.API
{
	public class GetSeasonData
	{
		private HttpEndPoints endPoints;

		private Action<bool, StatusCode, string, GetSeasonDataResult> callback;

		public GetSeasonData(HttpEndPoints endPoints)
		{
		}

		public void Get(Action<bool, StatusCode, string, GetSeasonDataResult> callback)
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
