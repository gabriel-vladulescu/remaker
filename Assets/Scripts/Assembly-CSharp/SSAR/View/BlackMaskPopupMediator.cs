using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.View
{
	public class BlackMaskPopupMediator : Mediator
	{
		[Inject]
		public BlackMaskPopup view { get; set; }

		[Inject]
		public HideBlackMaskPopupSignal HideBlackMaskPopupSignal { get; set; }

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
