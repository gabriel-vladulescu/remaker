using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.DailyLogin.View
{
	public class DailyLoginPopupMediator : Mediator
	{
		[Inject]
		public DailyLoginPopup view { get; set; }

		[Inject]
		public OnClaimDailyLoginRewardSuccessSignal OnClaimDailyLoginRewardSuccessSignal { get; set; }

		[Inject]
		public OnClaimDailyLoginBonusRewardSuccessSignal OnClaimDailyLoginBonusRewardSuccessSignal { get; set; }

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
