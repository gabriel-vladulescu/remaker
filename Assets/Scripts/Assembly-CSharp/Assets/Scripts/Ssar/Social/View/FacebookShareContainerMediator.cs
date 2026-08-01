using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Social.View
{
	public class FacebookShareContainerMediator : Mediator
	{
		[Inject]
		public FacebookShareContainer view { get; set; }

		[Inject]
		public OnShareFacebookSuccessSignal OnShareFacebookSuccessSignal { get; set; }

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
