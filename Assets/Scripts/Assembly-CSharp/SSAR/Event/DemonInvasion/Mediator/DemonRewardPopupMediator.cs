using Ssar.Event.DemonInvasion.Model;
using Ssar.Event.DemonInvasion.Popup;
using strange.extensions.mediation.impl;

namespace Ssar.Event.DemonInvasion.Mediator
{
	public class DemonRewardPopupMediator : strange.extensions.mediation.impl.Mediator
	{
		[Inject]
		public DemonRewardPopup rewardPopup { get; set; }

		[Inject]
		public OnClaimRewardSuccessSignal rewardSuccessSignal { get; set; }

		[Inject]
		public AddEventDemonTokenSuccessSignal addTokenSignal { get; set; }

		[Inject]
		public UnlockDemonPassSuccessSignal unlockSuccessSignal { get; set; }

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
