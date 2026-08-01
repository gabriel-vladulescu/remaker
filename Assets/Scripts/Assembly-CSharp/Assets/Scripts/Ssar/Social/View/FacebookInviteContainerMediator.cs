using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Social.View
{
	public class FacebookInviteContainerMediator : Mediator
	{
		[Inject]
		public FacebookInviteContainer view { get; set; }

		[Inject]
		public OnInviteFacebookSuccessSignal OnInviteFacebookSuccessSignal { get; set; }

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
