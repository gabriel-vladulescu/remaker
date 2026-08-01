using System;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class GetCurrentSeasonInfo
	{
		private HttpEndPoints endPoints;

		public GetCurrentSeasonInfo(HttpEndPoints endPoints)
		{
		}

		public void Get(Action<bool, StatusCode, string, GetCurrentSeasonInfoResult> callback)
		{
		}
	}
}
