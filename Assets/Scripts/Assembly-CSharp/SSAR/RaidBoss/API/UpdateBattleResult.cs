using System;
using SSAR.BattleSystem.System.Arena.Api;

namespace Ssar.RaidBoss.API
{
	public class UpdateBattleResult
	{
		private HttpEndPoints endPoints;

		private RaidDifficulty di;

		private string uid;

		private bool ibd;

		private Action<bool, StatusCode, string, UpdateBattleResultResponse> callback;

		public UpdateBattleResult(HttpEndPoints endPoints, RaidDifficulty di, string uid, bool ibd)
		{
		}

		public void Update(Action<bool, StatusCode, string, UpdateBattleResultResponse> callback)
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
