using Ssar.Event.EventLogin.Model;
using strange.extensions.mediation.impl;

namespace Ssar.Event.EventLogin.View
{
	public class EventLoginPopupMediator : Mediator
	{
		[Inject]
		public EventLoginPopup view { get; set; }

		[Inject]
		public OnClaimEventLoginRewardSuccessSignal claimSignal { get; set; }

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
