using Ssar.Event.DemonInvasion.Model;
using Ssar.Event.DemonInvasion.Popup;
using strange.extensions.mediation.impl;

namespace Ssar.Event.DemonInvasion.Mediator
{
	public class DemonInvasionLoginMediator : strange.extensions.mediation.impl.Mediator
	{
		[Inject]
		public DemonInvasionLoginPopup loginPopup { get; set; }

		[Inject]
		public OnClaimDailySuccessSignal dailySuccessSignal { get; set; }

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
