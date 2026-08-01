using Scripts.Config;
using strange.extensions.command.impl;

namespace Ssar.DailyChallenge.Command
{
	public class CheckEnterDailyChallengeOfflineCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public DailyChallengeConfig.Dungeon dungeon { get; set; }

		public override void Execute()
		{
		}

		private int[] GenerateRounds(int seed)
		{
			return null;
		}
	}
}
