using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Shop.View
{
	public class FlashSaleEventPopupMediator : Mediator
	{
		[Inject]
		public FlashSaleEventPopup view { get; set; }

		[Inject]
		public UpdateFlashSaleUISignal UpdateFlashSaleUiSignal { get; set; }

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
