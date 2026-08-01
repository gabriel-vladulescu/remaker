using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using strange.extensions.mediation.impl;

namespace SSAR.Shop.View
{
	public class BundlePackageOneProductPopupMediator : Mediator
	{
		[Inject]
		public BundlePackageOneProductPopup view { get; set; }

		[Inject]
		public OnBuyBundlePackageSuccessSignal OnBuyBundlePackageSuccessSignal { get; set; }

		[Inject]
		public OnBuyFirstTopUpPackageSuccessSignal OnBuyFirstTopUpPackageSuccessSignal { get; set; }

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		private void OnDestroy()
		{
		}

		private void Hide(FirstTimePurchaseProductInfo productInfo)
		{
		}
	}
}
