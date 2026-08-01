using System.Collections.Generic;
using Assets.Scripts.Ssar.Signal;
using SSAR.BattleSystem.System.Arena.Api;
using strange.extensions.command.impl;

namespace Scripts.Ssar.Arena
{
	public class GetArenaLeaderBoardDataCmd : Command
	{
		private bool[] flag;

		private int index;

		private List<UserAndRank> userAndRanks;

		[Inject]
		public OnUpdateArenaLeaderBoardSignal OnUpdateArenaLeaderBoardSignal { get; set; }

		public override void Execute()
		{
		}

		private void GetLeaderboard()
		{
		}

		private void GetDivision()
		{
		}

		private void CheckFinish()
		{
		}

		private void UpdateCurrentSeasonLeaderboard(List<UserAndRank> userAndRanks)
		{
		}

		private void UpdatePreviousSeasonLeaderboard(List<UserAndRank> userAndRanks)
		{
		}

		private void UpdateLeagueLeaderBoard(List<UserAndRank> userAndRanks)
		{
		}

		private TierName GetTier()
		{
			return default(TierName);
		}
	}
}
