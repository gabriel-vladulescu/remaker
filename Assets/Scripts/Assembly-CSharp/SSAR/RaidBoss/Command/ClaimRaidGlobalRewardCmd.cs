using Ssar.RaidBoss.API;
using Ssar.RaidBoss.Model;
using strange.extensions.command.impl;

namespace Ssar.RaidBoss.Command
{
	public class ClaimRaidGlobalRewardCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ClaimRaidGlobalRewardParameter Parameter { get; set; }

		[Inject]
		public LoadRaidGlobalProgressSignal ProgressSignal { get; set; }

		[Inject]
		public OnClaimGlobalRewardSuccessSignal SuccessSignal { get; set; }

		[Inject]
		public AddRewardFromClaimRaidGlobalSignal AddRewardSignal { get; set; }

		public override void Execute()
		{
		}

		private void CheckClaimable()
		{
		}

		private void Claim()
		{
		}

		private void OnClaimResponseSuccess(GlobalRewardStatus status)
		{
		}

		private void ShowError(string message)
		{
		}
	}
}
