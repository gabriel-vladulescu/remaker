using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.View
{
	public class MainSceneUserDataMediator : Mediator
	{
		[Inject]
		public UserDataView view { get; set; }

		[Inject]
		public OnChangeDisplayNameSuccessSignal OnChangeDisplayNameSuccessSignal { get; set; }

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
