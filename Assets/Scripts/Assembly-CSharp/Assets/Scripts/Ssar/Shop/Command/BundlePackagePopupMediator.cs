using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class BundlePackagePopupMediator : Mediator
	{
		[Inject]
		public BundlePackagePopup view { get; set; }

		[Inject]
		public OnBuyBundlePackageSuccessSignal OnBuyBundlePackageSuccessSignal { get; set; }

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
