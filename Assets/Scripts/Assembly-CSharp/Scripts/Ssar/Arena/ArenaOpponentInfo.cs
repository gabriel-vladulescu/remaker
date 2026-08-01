using SSAR.BattleSystem.System.Arena.Api;

namespace Scripts.Ssar.Arena
{
	public class ArenaOpponentInfo
	{
		public string opponentId;

		public MainCharacterData MainCharacterData;

		public UserSeasonProgress UserSeasonProgress;

		public int rank;

		public ArenaOpponentInfo(string opponentId, MainCharacterData mainCharacterData, UserSeasonProgress userSeasonProgress, int rank)
		{
		}

		public ArenaOpponentInfo()
		{
		}
	}
}
