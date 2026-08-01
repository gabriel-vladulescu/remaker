using Ssar.RaidBoss.Model;

namespace Ssar.RaidBoss.Command
{
	public class ShowRaidStartNewSeasonParameter
	{
		public RaidSeasonRankData currentRank;

		public RaidSeasonRankData previousRank;

		public ShowRaidStartNewSeasonParameter(RaidSeasonRankData currentRank, RaidSeasonRankData previousRank)
		{
		}
	}
}
