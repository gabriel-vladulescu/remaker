using SSAR.BattleSystem.System.Arena.Api;

namespace Scripts.Ssar.Arena
{
	public class ArenaJoinNewSeasonCallBack
	{
		public bool Success { get; set; }

		public StatusCode StatusCode { get; set; }

		public string Message { get; set; }

		public JoinSeasonResult JoinSeasonResult { get; set; }

		public ArenaJoinNewSeasonCallBack(bool success, StatusCode statusCode, string message, JoinSeasonResult joinSeasonResult)
		{
		}
	}
}
