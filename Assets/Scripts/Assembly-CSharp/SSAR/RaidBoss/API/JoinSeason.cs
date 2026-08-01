using System;
using SSAR.BattleSystem.System.Arena.Api;

namespace Ssar.RaidBoss.API
{
	public class JoinSeason
	{
		private HttpEndPoints endPoints;

		private string uid;

		private readonly string clientVersion;

		private Action<bool, StatusCode, string> callback;

		public JoinSeason(HttpEndPoints endPoints, string uid, string clientVersion)
		{
		}

		public void Join(Action<bool, StatusCode, string> callback)
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
