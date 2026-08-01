namespace SSAR.BattleSystem.System.Arena.Api
{
	public interface HttpEndPoints
	{
		string CurrentTimeInMillis();

		string JoinSeason();

		string FindOpponent();

		string UpdateDuelResult();

		string GetUserMmrRank();

		string GetLeaderboard();

		string GetClaimReward();

		string GetCurrentSeasonInfo();

		string GetUserSeasonProgress();

		string GetPreviousSeasonId();

		string GetUserSeasonProgressesAndRewardStatus();

		string GetDivisionLeaderboard();
	}
}
