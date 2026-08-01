using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Social.View
{
	public class FacebookLikeContainerMediator : Mediator
	{
		[Inject]
		public FacebookLikeContainer view { get; set; }

		[Inject]
		public OnLikedFacebookSuccessSignal OnLikedFacebookSuccessSignal { get; set; }

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
