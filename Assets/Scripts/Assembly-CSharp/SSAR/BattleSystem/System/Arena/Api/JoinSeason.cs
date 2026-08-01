using System;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class JoinSeason
	{
		private HttpEndPoints endPoints;

		private string userId;

		private readonly int level;

		private readonly long power;

		private readonly string clientVersion;

		public JoinSeason(HttpEndPoints endPoints, string userId, int level, long power, string clientVersion)
		{
		}

		public void Join(Action<bool, StatusCode, string, JoinSeasonResult> callback)
		{
		}
	}
}
