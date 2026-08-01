using System;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class FindOpponent
	{
		public static string DUEL_ID;

		private HttpEndPoints endPoints;

		private string userId;

		private string clientVersion;

		public FindOpponent(HttpEndPoints endPoints, string userId, string clientVersion)
		{
		}

		public void Find(Action<bool, StatusCode, string, FindOpponentResult> callback)
		{
		}
	}
}
