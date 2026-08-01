using System;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class UpdateDuelResult
	{
		private HttpEndPoints endPoints;

		private string userId;

		private string opponentId;

		private DuelResult result;

		private readonly int level;

		private readonly long power;

		public UpdateDuelResult(HttpEndPoints endPoints, string userId, string opponentId, DuelResult result, int level, long power)
		{
		}

		public void Update(Action<bool, StatusCode, string, UpdateDuelResultData> callback)
		{
		}

		private string Xor(string input)
		{
			return null;
		}
	}
}
