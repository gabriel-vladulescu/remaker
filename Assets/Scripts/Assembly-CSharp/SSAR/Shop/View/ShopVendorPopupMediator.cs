using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Shop.View
{
	public class ShopVendorPopupMediator : Mediator
	{
		[Inject]
		public ShopVendorPopup popup { get; set; }

		[Inject]
		public OnBuyShopVendorItemSuccessSignal OnBuyShopVendorItemSuccessSignal { get; set; }

		[Inject]
		public OnRefreshShopVendorSuccessSignal OnRefreshShopVendorSuccessSignal { get; set; }

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
