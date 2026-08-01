using System;
using System.Collections.Generic;
using AppsFlyerSDK;

namespace Assets.Scripts.Ssar.AdMob
{
	public class IronSourceAdsService : IAdsService
	{
		private const string placement_name = "GeneralPlacement";

		private string ironSourceAppKey;

		private bool isVideoAvailable;

		private Action<RewardVideoResult> callBack;

		public IronSourceAdsService(string ironSourceAppKey)
		{
		}

		public void Initialize()
		{
		}

		public void RequestRewardVideo()
		{
		}

		public bool IsRewardVideoAlready()
		{
			return false;
		}

		public void ShowRewardVideo(Action<RewardVideoResult> callBack)
		{
		}

		private void ImpressionSuccessEvent(IronSourceImpressionData impressionData)
		{
		}

		public void LogAdRevenue(string adsNetwork, AppsFlyerAdRevenueMediationNetworkType networkType, double revenue, string currency, Dictionary<string, string> dictionary)
		{
		}

		private void RewardedVideoOnAdAvailable(IronSourceAdInfo adInfo)
		{
		}

		private void RewardedVideoOnAdUnavailable()
		{
		}

		private void RewardedVideoOnAdOpenedEvent(IronSourceAdInfo adInfo)
		{
		}

		private void RewardedVideoOnAdClosedEvent(IronSourceAdInfo adInfo)
		{
		}

		private void RewardedVideoOnAdRewardedEvent(IronSourcePlacement placement, IronSourceAdInfo adInfo)
		{
		}

		private void RewardedVideoOnAdShowFailedEvent(IronSourceError error, IronSourceAdInfo adInfo)
		{
		}

		private void RewardedVideoOnAdClickedEvent(IronSourcePlacement placement, IronSourceAdInfo adInfo)
		{
		}
	}
}
