namespace SSAR.BattleSystem.System.Arena.Api
{
	public class GetUserSeasonProgressesAndRewardStatusResult
	{
		public GetUserSeasonProgressResult currentSeason;

		public GetUserSeasonProgressResult previousSeason;

		public bool rewardClaimStatus;

		public MmrRank mmrRankOfCurrentSeason;

		public MmrRank mmrRankOfPreviousSeason;

		public override string ToString()
		{
			return null;
		}
	}
}
