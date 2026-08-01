using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Shop.View
{
	public class NewSubscribePackageCategoryPopupMediator : Mediator
	{
		[Inject]
		public HideNewSubscribePackageCategoryPopupSignal HideNewSubscribePackageCategoryPopupSignal { get; set; }

		[Inject]
		public NewSubscribePackageCategoryPopup view { get; set; }

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
