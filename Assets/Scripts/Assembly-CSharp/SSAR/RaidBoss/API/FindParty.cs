using System;
using SSAR.BattleSystem.System.Arena.Api;

namespace Ssar.RaidBoss.API
{
	public class FindParty
	{
		private HttpEndPoints endPoints;

		private RaidDifficulty di;

		private int gi;

		private int p;

		private string uid;

		private bool sm;

		private readonly string clientVersion;

		private Action<bool, StatusCode, string, FindPartyResult> callback;

		public FindParty(HttpEndPoints endPoints, RaidDifficulty di, int gi, int p, string uid, bool sm, string clientVersion)
		{
		}

		public void Find(Action<bool, StatusCode, string, FindPartyResult> callback)
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
