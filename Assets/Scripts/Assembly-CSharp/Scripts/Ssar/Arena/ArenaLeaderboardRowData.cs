using SSAR.BattleSystem.System.Arena.Api;

namespace Scripts.Ssar.Arena
{
	public class ArenaLeaderboardRowData
	{
		public string userId;

		public int rank;

		public string displayName;

		public int level;

		public long power;

		public int stars;

		public int characterId;

		public bool isWin;

		public ArenaReplayData ArenaReplayData;

		public string countryCode;

		public ArenaLeaderboardRowData(UserAndRank userAndRank)
		{
		}

		public ArenaLeaderboardRowData()
		{
		}

		public void SaveBattleReplay(ArenaReplayData arenaReplayData)
		{
		}

		public ArenaLeaderboardRowData Record(ArenaOpponentInfo arenaOpponentInfo)
		{
			return null;
		}
	}
}
