using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Shop.View
{
	public class UnlockAllCharactersPopupMediator : Mediator
	{
		[Inject]
		public UnlockAllCharactersPackagePopup view { get; set; }

		[Inject]
		public BuyUnlockAllCharactersPackageSuccessSignal BuyUnlockAllCharactersPackageSuccessSignal { get; set; }

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
