using System.Collections.Generic;
using Assets.Scripts.Core.Scheduling;
using SSAR.BattleSystem.System.Arena.Api;

namespace Scripts.Ssar.Arena
{
	public class ArenaLeaderBoardCacheData : SimTimeObserver
	{
		private bool hasGetData;

		private List<ArenaLeaderboardRowData> currentLeague;

		private List<ArenaLeaderboardRowData> currentLeaderboard;

		private List<ArenaLeaderboardRowData> previousLeaderboard;

		private RecordCacheData recordCacheData;

		private float timeRefreshLeaderBoard;

		private float intervalRefreshLeaderBoard;

		private float time;

		private float delay;

		public void UpdateCooldown(float cooldown)
		{
		}

		public List<ArenaLeaderboardRowData> GetRowDatas(ArenaPreparationTabType tabType)
		{
			return null;
		}

		public bool HasGetArenaLeaderBoardDataFromServer()
		{
			return false;
		}

		public void SetHasGetArenaLeaderBoardDataFromServer(bool hasGetData)
		{
		}

		public void ClearLeaderBoard()
		{
		}

		public void UpdateCurrentSeasonLeaderBoard(List<UserAndRank> userAndRanks)
		{
		}

		public void UpdateCurrentLeague(List<UserAndRank> userAndRanks)
		{
		}

		public void UpdatePreviousSeasonLeaderBard(List<UserAndRank> userAndRanks)
		{
		}

		public void ResetRecord(string userId)
		{
		}

		public void AddRecord(bool isWin, ArenaOpponentInfo arenaOpponentInfo, ArenaReplayData arenaReplayData)
		{
		}

		public void RemoveLastOpponent()
		{
		}

		public LastArenaOpponentInfo GetLastOpponentInfo()
		{
			return null;
		}

		public void ResetLeaderBoard()
		{
		}

		public void SetOpponentInfo(ArenaOpponentInfo arenaOpponentInfo, string duelId)
		{
		}

		private string UserId()
		{
			return null;
		}

		public static string FilePath()
		{
			return null;
		}

		private RecordCacheData LoadCacheData()
		{
			return null;
		}

		private void Save()
		{
		}

		public bool HasUserData()
		{
			return false;
		}

		public int GetTimeToRefreshLeaderboard()
		{
			return 0;
		}

		public void OnSimTime(uint dt)
		{
		}
	}
}
