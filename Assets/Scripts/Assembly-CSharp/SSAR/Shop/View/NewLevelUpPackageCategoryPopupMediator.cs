using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Shop.View
{
	public class NewLevelUpPackageCategoryPopupMediator : Mediator
	{
		[Inject]
		public NewLevelUpPackageCategoryPopup view { get; set; }

		[Inject]
		public HideNewLevelUpPackageCategoryPopupSignal HideNewLevelUpPackageCategoryPopupSignal { get; set; }

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
