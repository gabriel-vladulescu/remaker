using System;

namespace Ssar.RaidBoss.Command
{
	public class LoadSeasonalRewardsStatusParameter
	{
		public RaidDifficulty[] difficulties;

		public Action callback;

		public LoadSeasonalRewardsStatusParameter(RaidDifficulty[] difficulties, Action callback = null)
		{
		}
	}
}
