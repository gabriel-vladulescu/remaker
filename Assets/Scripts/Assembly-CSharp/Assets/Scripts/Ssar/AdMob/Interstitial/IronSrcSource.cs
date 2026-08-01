using System;

namespace Assets.Scripts.Ssar.AdMob.Interstitial
{
	public class IronSrcSource
	{
		private Action<bool> callback;

		private UnityMainThreadDispatcher mainThreadDispatcher;

		public void Init(string ironsrcAppKey)
		{
		}

		public void Show(Action<bool> callback)
		{
		}

		public bool IsInterstitialReady()
		{
			return false;
		}

		public void LoadInterstitial()
		{
		}

		private void InterstitialOnAdReadyEvent(IronSourceAdInfo adInfo)
		{
		}

		private void InterstitialOnAdLoadFailed(IronSourceError ironSourceError)
		{
		}

		private void InterstitialOnAdOpenedEvent(IronSourceAdInfo adInfo)
		{
		}

		private void InterstitialOnAdClickedEvent(IronSourceAdInfo adInfo)
		{
		}

		private void InterstitialOnAdShowFailedEvent(IronSourceError ironSourceError, IronSourceAdInfo adInfo)
		{
		}

		private void InterstitialOnAdClosedEvent(IronSourceAdInfo adInfo)
		{
		}

		private void InterstitialOnAdShowSucceededEvent(IronSourceAdInfo adInfo)
		{
		}
	}
}
