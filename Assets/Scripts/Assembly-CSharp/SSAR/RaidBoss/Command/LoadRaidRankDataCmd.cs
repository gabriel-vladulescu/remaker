using SSAR.BattleSystem.System.Arena.Api;
using Ssar.RaidBoss.Model;
using strange.extensions.command.impl;

namespace Ssar.RaidBoss.Command
{
	public class LoadRaidRankDataCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public LoadRaidRankDataParameter Parameter { get; set; }

		[Inject]
		public UpdateRaidTimeLeftViewSignal UpdateRaidTimeLeftViewSignal { get; set; }

		[Inject]
		public UpdateRaidPersonalInfoViewSignal UpdateRaidPersonalInfoViewSignal { get; set; }

		public override void Execute()
		{
		}

		private void GetCurrentRank()
		{
		}

		private void GetPreviousRank()
		{
		}

		private void ShowError(StatusCode code, string message)
		{
		}
	}
}
