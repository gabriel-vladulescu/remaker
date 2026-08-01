using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Shop.View
{
	public class SubscribePackagePopupMediator : Mediator
	{
		[Inject]
		public SubscribePackagePopup view { get; set; }

		[Inject]
		public OnBuySubscriptionPackageSuccessSignal OnBuySubscriptionPackageSuccessSignal { get; set; }

		[Inject]
		public OnClaimSubscriptionPackageRewardSuccessSignal OnClaimSubscriptionPackageRewardSuccessSignal { get; set; }

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
