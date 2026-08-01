using SimpleJSON;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class ResponseFromServer
	{
		private string json;

		private JSONNode root;

		public ResponseFromServer(string json)
		{
		}

		public StatusCode ShowStatusCode()
		{
			return default(StatusCode);
		}

		public string ShowMessage()
		{
			return null;
		}

		public JSONNode Result()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
