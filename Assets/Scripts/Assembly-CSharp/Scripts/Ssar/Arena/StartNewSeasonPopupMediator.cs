using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Scripts.Ssar.Arena
{
	public class StartNewSeasonPopupMediator : Mediator
	{
		[Inject]
		public StartNewSeasonPopup view { get; set; }

		[Inject]
		public OnClaimEndSeasonRewardFailedSignal OnClaimEndSeasonRewardFailedSignal { get; set; }

		[Inject]
		public OnClaimEndSeasonRewardSuccessSignal OnClaimEndSeasonRewardSuccessSignal { get; set; }

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
