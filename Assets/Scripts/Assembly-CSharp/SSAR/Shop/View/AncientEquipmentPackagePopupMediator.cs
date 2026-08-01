using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Shop.View
{
	public class AncientEquipmentPackagePopupMediator : Mediator
	{
		[Inject]
		public AncientEquipmentPackagePopup view { get; set; }

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
