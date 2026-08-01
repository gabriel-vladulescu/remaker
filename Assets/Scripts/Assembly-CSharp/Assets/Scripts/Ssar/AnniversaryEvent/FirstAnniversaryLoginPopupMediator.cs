using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	public class FirstAnniversaryLoginPopupMediator : Mediator
	{
		[Inject]
		public FirstAnniversaryLoginPopup view { get; set; }

		[Inject]
		public OnClaimFirstAnniversaryLoginRewardSuccessSignal claimSignal { get; set; }

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
