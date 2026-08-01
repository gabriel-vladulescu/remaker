using System;
using Scripts.Config;

namespace Ssar.DailyChallenge.Logic
{
	public class DailyChallengeLevelUp
	{
		private DailyChallengeConfig.Round round;

		private Action<int> onFinished;

		public DailyChallengeLevelUp(DailyChallengeConfig.Round round, Action<int> onFinished)
		{
		}

		public void Execute()
		{
		}

		private int[] GetBuffIds()
		{
			return null;
		}
	}
}
