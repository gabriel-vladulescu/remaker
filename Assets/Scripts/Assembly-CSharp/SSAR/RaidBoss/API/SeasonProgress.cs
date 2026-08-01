using System.Collections.Generic;

namespace Ssar.RaidBoss.API
{
	public class SeasonProgress
	{
		public bool joined;

		public Dictionary<RaidDifficulty, Progress> progressByDifficulty;

		public override string ToString()
		{
			return null;
		}
	}
}
