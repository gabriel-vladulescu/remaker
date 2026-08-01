using Assets.Scripts.Ssar.Signal;
using SSAR.BattleSystem.System.Arena.Api;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Scripts.Ssar.Arena
{
	public class ClaimEndSeasonRewardCmd : Command
	{
		[Inject]
		public AddRewardFromClaimArenaEndSeasonSignal AddRewardFromClaimArenaEndSeasonSignal { get; set; }

		[Inject]
		public OnClaimEndSeasonRewardSuccessSignal OnClaimEndSeasonRewardSuccessSignal { get; set; }

		[Inject]
		public UpdateArenaTimeLeftViewSignal UpdateArenaTimeLeftViewSignal { get; set; }

		[Inject]
		public RankData RankData { get; set; }

		[Inject]
		public OnClaimEndSeasonRewardFailedSignal OnClaimEndSeasonRewardFailedSignal { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private void Claim(RankData rankData)
		{
		}

		private void ShowError(StatusCode statusCode, string message)
		{
		}

		private string UserId()
		{
			return null;
		}

		private void Metric()
		{
		}
	}
}
