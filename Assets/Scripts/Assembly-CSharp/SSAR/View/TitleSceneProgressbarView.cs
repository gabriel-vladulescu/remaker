using System;
using Scripts.Config.Remote;
using strange.extensions.mediation.impl;

namespace SSAR.View
{
	public class TitleSceneProgressbarView : strange.extensions.mediation.impl.View
	{
		public UILabel lb_progress;

		public UILabel lb_downloadConfig;

		public UIProgressBar progressBar;

		private TextLoading textDownloadCOnfig;

		private bool showTextDownload;

		private int timeSleep;

		public Action onFinish;

		public Action onDownloadConfig;

		private bool showVideo;

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void Init()
		{
		}

		private void Update()
		{
		}

		public void ShowDownloadConfigProgress(ConfigVersion downloadingConfigVersion, string configName, int percent)
		{
		}

		private void UpdateDownloadProgress(int percent, string text)
		{
		}

		public void FinishDownloadAssets()
		{
		}

		public void ShowDownloadAssetsProgress(float progress)
		{
		}

		public void FinishCheckConfig()
		{
		}
	}
}
