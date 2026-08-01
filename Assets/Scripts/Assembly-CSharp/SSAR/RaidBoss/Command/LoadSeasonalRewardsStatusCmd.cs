using System.Collections.Generic;
using Ssar.RaidBoss.Model;
using strange.extensions.command.impl;

namespace Ssar.RaidBoss.Command
{
	public class LoadSeasonalRewardsStatusCmd : strange.extensions.command.impl.Command
	{
		private List<RaidDifficulty> loadingDifficulties;

		[Inject]
		public LoadSeasonalRewardsStatusParameter Parameter { get; set; }

		[Inject]
		public UpdateRaidTimeLeftViewSignal UpdateRaidTimeLeftViewSignal { get; set; }

		public override void Execute()
		{
		}

		private void LoadRewardStatus(RaidDifficulty difficulty)
		{
		}
	}
}
