using System;
using Scripts.Ssar.Arena;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class GetDivisionLeaderboard
	{
		private HttpEndPoints endPoints;

		private TierName tier;

		private ArenaDivision division;

		public GetDivisionLeaderboard(HttpEndPoints endPoints, TierName tier, ArenaDivision division)
		{
		}

		public void Get(Action<bool, StatusCode, string, GetDivisionLeaderboardResult> callback)
		{
		}
	}
}
