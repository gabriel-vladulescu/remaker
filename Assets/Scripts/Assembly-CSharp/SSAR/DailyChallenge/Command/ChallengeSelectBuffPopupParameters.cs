using System;
using Scripts.Config;

namespace Ssar.DailyChallenge.Command
{
	public class ChallengeSelectBuffPopupParameters
	{
		public DailyChallengeConfig.Round round;

		public int[] buffIds;

		public Action<int> onFinish;

		public ChallengeSelectBuffPopupParameters(DailyChallengeConfig.Round round, int[] buffIds, Action<int> onFinish = null)
		{
		}
	}
}
