using System.Collections.Generic;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class GetLeaderboardResult
	{
		private readonly Seasons[] seasons;

		public List<Leaderboard> leaderboards;

		public GetLeaderboardResult(Seasons[] seasons)
		{
		}

		public Leaderboard Current()
		{
			return null;
		}

		public Leaderboard Previous()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		private Leaderboard CreateEmptyLeaderboard()
		{
			return null;
		}
	}
}
