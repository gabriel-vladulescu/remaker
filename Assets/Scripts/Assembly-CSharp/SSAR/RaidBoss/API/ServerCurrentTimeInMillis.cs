using System;
using SSAR.BattleSystem.System.Arena.Api;

namespace Ssar.RaidBoss.API
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
