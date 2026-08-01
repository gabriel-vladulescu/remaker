namespace Ssar.RaidBoss.API
{
	public interface HttpEndPoints
	{
		string CurrentTimeInMillis();

		string GetLeaderboard();

		string GetRank();

		string GetUpdateBattleResult();

		string GetSeasonData();

		string FindParty();

		string GetUserProgress();

		string JoinSeason();
	}
}
