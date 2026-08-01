using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Shop.View
{
	public class PiggyBankPopupMediator : Mediator
	{
		[Inject]
		public PiggyBankPopup view { get; set; }

		[Inject]
		public OnBuyPiggyBankSuccessSignal OnBuyPiggyBankSuccessSignal { get; set; }

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
