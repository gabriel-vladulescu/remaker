using System.Collections.Generic;

namespace Ssar.RaidBoss.API
{
	public class GetRankingResponse
	{
		public Dictionary<RaidDifficulty, Rank> rankByDifficulty;

		public override string ToString()
		{
			return null;
		}
	}
}
