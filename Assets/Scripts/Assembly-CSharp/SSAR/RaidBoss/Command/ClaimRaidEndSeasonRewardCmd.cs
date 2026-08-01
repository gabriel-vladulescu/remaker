using Scripts.Config;
using Ssar.Analytics.Metrics;
using Ssar.RaidBoss.Model;
using strange.extensions.command.impl;

namespace Ssar.RaidBoss.Command
{
	public class ClaimRaidEndSeasonRewardCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public RaidLeagueRankData RankData { get; set; }

		[Inject]
		public AddRewardFromClaimRaidEndSeasonSignal AddRewardFromClaimRaidEndSeasonSignal { get; set; }

		[Inject]
		public OnClaimRaidEndSeasonRewardSuccessSignal OnClaimRaidEndSeasonRewardSuccessSignal { get; set; }

		[Inject]
		public UpdateRaidTimeLeftViewSignal UpdateRaidTimeLeftViewSignal { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private void Claim(RaidLeagueRankData rankData)
		{
		}

		private void OnClaimResponseSuccess(RaidLeagueRankData rankData)
		{
		}

		private void ShowError(string message)
		{
		}

		private void ClaimRaidSeasonalRewardMetric()
		{
		}
	}
}
