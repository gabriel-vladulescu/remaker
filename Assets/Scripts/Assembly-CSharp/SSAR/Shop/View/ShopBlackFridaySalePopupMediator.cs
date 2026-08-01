using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Shop.View
{
	public class ShopBlackFridaySalePopupMediator : Mediator
	{
		[Inject]
		public ShopBlackFridaySalePopup popup { get; set; }

		[Inject]
		public OnBuyShopBlackFridayItemSuccessSignal OnBuyShopBlackFridayItemSuccessSignal { get; set; }

		[Inject]
		public OnBuyShopBlackFridayPackSuccessSignal OnBuyShopBlackFridayPackSuccessSignal { get; set; }

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
