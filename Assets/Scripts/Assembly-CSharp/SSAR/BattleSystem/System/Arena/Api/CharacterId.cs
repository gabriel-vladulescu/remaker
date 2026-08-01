namespace SSAR.BattleSystem.System.Arena.Api
{
	public class CharacterId
	{
		private string deviceId;

		private string characterName;

		private int characterCreationTime;

		private string raw;

		private const string format = "{0}_{1}_{2}";

		public CharacterId(string deviceId, string characterName, int characterCreationTime)
		{
		}

		public CharacterId(string characterName, int characterCreationTime)
		{
		}

		public CharacterId(string raw)
		{
		}

		public virtual string Obtain()
		{
			return null;
		}
	}
}
