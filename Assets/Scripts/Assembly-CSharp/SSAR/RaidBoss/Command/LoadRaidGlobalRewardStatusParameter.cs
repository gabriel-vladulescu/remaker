using System;

namespace Ssar.RaidBoss.Command
{
	public class LoadRaidGlobalRewardStatusParameter
	{
		public RaidDifficulty difficulty;

		public Action callback;

		public LoadRaidGlobalRewardStatusParameter(RaidDifficulty difficulty, Action callback)
		{
		}
	}
}
