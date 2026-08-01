using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Social.View
{
	public class FacebookLoginContainerMediator : Mediator
	{
		[Inject]
		public FacebookLoginContainer view { get; set; }

		[Inject]
		public OnJoinFacebookSuccessSignal OnJoinFacebookSuccessSignal { get; set; }

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
