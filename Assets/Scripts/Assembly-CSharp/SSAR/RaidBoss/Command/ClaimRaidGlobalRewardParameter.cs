using System;

namespace Ssar.RaidBoss.Command
{
	public class ClaimRaidGlobalRewardParameter
	{
		public RaidDifficulty difficulty;

		public int rewardId;

		public Action callback;

		public ClaimRaidGlobalRewardParameter(RaidDifficulty difficulty, int rewardId, Action callback)
		{
		}
	}
}
