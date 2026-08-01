using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Ssar.Event.Xmas
{
	public class XmasLoginPopupMediator : Mediator
	{
		[Inject]
		public XmasLoginPopup view { get; set; }

		[Inject]
		public OnClaimXmasLoginRewardSuccessSignal claimSignal { get; set; }

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
