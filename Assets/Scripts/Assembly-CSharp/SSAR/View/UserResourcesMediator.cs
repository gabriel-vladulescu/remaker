using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.View
{
	public class UserResourcesMediator : Mediator
	{
		[Inject]
		public OnSaveToCloudSuccessSignal ShowAutoSaveNotifyPopupSignal { get; set; }

		[Inject]
		public UserResourcesView UserResourcesView { get; set; }

		[Inject]
		public OnBuyDoubleExppackageSuccessSignal OnBuyDoubleExppackageSuccessSignal { get; set; }

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		private void OnDestroy()
		{
		}

		private void FxSave()
		{
		}
	}
}
