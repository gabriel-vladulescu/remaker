using System;

namespace Ssar.RaidBoss.Model
{
	[Serializable]
	public class RaidLeagueRankData
	{
		public RaidDifficulty difficulty;

		public int rank;

		public bool IsUnrank()
		{
			return false;
		}
	}
}
