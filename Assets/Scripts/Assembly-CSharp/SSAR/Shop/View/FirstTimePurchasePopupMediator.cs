using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using strange.extensions.mediation.impl;

namespace SSAR.Shop.View
{
	public class FirstTimePurchasePopupMediator : Mediator
	{
		[Inject]
		public OnBuyFirstTopUpPackageSuccessSignal OnBuyFirstTopUpPackageSuccessSignal { get; set; }

		[Inject]
		public FirstTimePurchasePopup view { get; set; }

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnBuySuccess(FirstTimePurchaseProductInfo productInfo)
		{
		}
	}
}
