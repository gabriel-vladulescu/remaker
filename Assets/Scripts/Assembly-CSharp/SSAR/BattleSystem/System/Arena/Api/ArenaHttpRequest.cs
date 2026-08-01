using System;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class ArenaHttpRequest
	{
		private int timeout;

		public ArenaHttpRequest()
		{
		}

		public ArenaHttpRequest(int timeout)
		{
		}

		public void Act(string url, Action<StatusCode, string, ResponseFromServer> successCallback, Action<StatusCode, string> failedCallback)
		{
		}

		public void ActPost(string url, string text, Action<StatusCode, string, ResponseFromServer> successCallback, Action<StatusCode, string> failedCallback)
		{
		}

		private int GetTimeout()
		{
			return 0;
		}
	}
}
