using System;
using System.Collections.Generic;

namespace Ssar.RaidBoss.Model
{
	[Serializable]
	public class RaidSeasonRankData
	{
		private Dictionary<RaidDifficulty, RaidLeagueRankData> ranks;

		public void SetRankData(RaidLeagueRankData rankData)
		{
		}

		public RaidLeagueRankData GetRankData(RaidDifficulty difficulty)
		{
			return null;
		}

		public RaidLeagueRankData GetHighestRank()
		{
			return null;
		}
	}
}
