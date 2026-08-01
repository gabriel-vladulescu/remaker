using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.DailyLogin.View
{
	public class DailyRewardPopupMediator : Mediator
	{
		[Inject]
		public DailyRewardPopup view { get; set; }

		[Inject]
		public OnClaimDailyRewardSuccessSignal OnClaimDailyRewardSuccessSignal { get; set; }

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
