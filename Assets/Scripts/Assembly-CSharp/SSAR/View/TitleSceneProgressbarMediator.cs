using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.View
{
	public class TitleSceneProgressbarMediator : Mediator
	{
		[Inject]
		public TitleSceneProgressbarView view { get; set; }

		[Inject]
		public FinishCheckConfigSignal FinishCheckConfigSignal { get; set; }

		[Inject]
		public ShowConfigDownloadingProgressSignal ShowConfigDownloadingProgressSignal { get; set; }

		[Inject]
		public DownloadDynamicAssetProgressSignal DownloadDynamicAssetProgressSignal { get; set; }

		[Inject]
		public FinishDownloadDynamicAssetSignal FinishDownloadDynamicAssetSignal { get; set; }

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
