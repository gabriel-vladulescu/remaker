using Ssar.RaidBoss.Model;
using strange.extensions.mediation.impl;

namespace Ssar.RaidBoss.View
{
	public class RaidGlobalProgressMediator : Mediator
	{
		[Inject]
		public RaidGlobalProgressView view { get; set; }

		[Inject]
		public OnLoadRaidGlobalProgressSuccessSignal LoadProgressSuccessSignal { get; set; }

		[Inject]
		public OnLoadRaidGlobalRewardStatusSuccessSignal LoadStatusSuccessSignal { get; set; }

		[Inject]
		public OnClaimGlobalRewardSuccessSignal ClaimRewardSuccessSignal { get; set; }

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
