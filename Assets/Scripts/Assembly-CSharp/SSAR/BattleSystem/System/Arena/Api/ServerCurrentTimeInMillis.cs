using System;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class ServerCurrentTimeInMillis
	{
		private HttpEndPoints endPoints;

		public ServerCurrentTimeInMillis(HttpEndPoints endPoints)
		{
		}

		public void Request(Action<bool, StatusCode, string, long> callback)
		{
		}
	}
}
