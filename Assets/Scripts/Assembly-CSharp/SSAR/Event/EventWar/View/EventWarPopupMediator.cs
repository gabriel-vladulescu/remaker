using Ssar.Event.EventWar.Model;
using strange.extensions.mediation.impl;

namespace Ssar.Event.EventWar.View
{
	public class EventWarPopupMediator : Mediator
	{
		[Inject]
		public EventWarPopup view { get; set; }

		[Inject]
		public OnClaimEventWarRewardSuccessSignal claimSignal { get; set; }

		[Inject]
		public OnAddEventWarTokenSuccessSignal addTokenSignal { get; set; }

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
