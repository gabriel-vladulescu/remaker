using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Shop.View
{
	public class FlashSaleOreRuneBundlePopupMediator : Mediator
	{
		[Inject]
		public FlashSaleOreRuneBundlePopup view { get; set; }

		[Inject]
		public BuyFlashSaleOreRuneBundleSuccessSignal BuyFlashSaleOreRuneBundleSuccessSignal { get; set; }

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
