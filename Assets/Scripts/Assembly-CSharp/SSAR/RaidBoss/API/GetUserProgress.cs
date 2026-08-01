using System;
using SSAR.BattleSystem.System.Arena.Api;

namespace Ssar.RaidBoss.API
{
	public class GetUserProgress
	{
		private HttpEndPoints endPoints;

		private readonly Season[] seasons;

		private string uid;

		private Action<bool, StatusCode, string, GetUserProgressResult> callback;

		public GetUserProgress(HttpEndPoints endPoints, Season[] seasons, string uid)
		{
		}

		public void Get(Action<bool, StatusCode, string, GetUserProgressResult> callback)
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
