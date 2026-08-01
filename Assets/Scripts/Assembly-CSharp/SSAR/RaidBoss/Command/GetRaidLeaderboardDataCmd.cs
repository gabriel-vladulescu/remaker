using Ssar.RaidBoss.Model;
using strange.extensions.command.impl;

namespace Ssar.RaidBoss.Command
{
	public class GetRaidLeaderboardDataCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public RaidDifficulty Difficulty { get; set; }

		[Inject]
		public OnUpdateRaidLeaderboardSignal OnUpdateRaidLeaderboardSignal { get; set; }

		public override void Execute()
		{
		}

		private void GetLeaderboard()
		{
		}
	}
}
