using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Scripts.Ssar.Arena
{
	public class UserInfoPopupMediator : Mediator
	{
		[Inject]
		public ReshowArenaUserInfoSignal ReshowArenaUserInfoSignal { get; set; }

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		private void OnDestroy()
		{
		}

		private void Reshow()
		{
		}
	}
}
