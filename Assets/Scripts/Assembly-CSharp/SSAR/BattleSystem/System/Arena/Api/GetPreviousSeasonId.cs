using System;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class GetPreviousSeasonId
	{
		private HttpEndPoints endPoints;

		public GetPreviousSeasonId(HttpEndPoints endPoints)
		{
		}

		public void Get(Action<bool, StatusCode, string, GetPreviousSeasonIdResult> callback)
		{
		}
	}
}
