using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Ssar.Event.Xmas
{
	public class XmasWarPopupMediator : Mediator
	{
		[Inject]
		public XmasWarPopup view { get; set; }

		[Inject]
		public OnClaimXmasWarMilestoneSuccessSignal claimSignal { get; set; }

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
