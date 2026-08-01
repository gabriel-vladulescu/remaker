using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Utils
{
	public class StreamVideoMediator : Mediator
	{
		[Inject]
		public StreamVideo view { get; set; }

		[Inject]
		public ShowStreamVideoProgressTextSignal ShowStreamVideoProgressTextSignal { get; set; }

		[Inject]
		public HideStreamVideoProgressTextSignal HideStreamVideoProgressTextSignal { get; set; }

		[Inject]
		public HideStreamVideoPopupSignal HideStreamVideoPopupSignal { get; set; }

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
