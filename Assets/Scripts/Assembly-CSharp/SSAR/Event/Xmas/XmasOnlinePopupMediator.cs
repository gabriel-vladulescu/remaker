using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Ssar.Event.Xmas
{
	public class XmasOnlinePopupMediator : Mediator
	{
		[Inject]
		public XmasOnlinePopup view { get; set; }

		[Inject]
		public OnClaimXmasOnlineRewardSuccessSignal claimSignal { get; set; }

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
