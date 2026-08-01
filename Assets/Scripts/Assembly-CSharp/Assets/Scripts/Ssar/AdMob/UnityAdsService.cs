using System;

namespace Assets.Scripts.Ssar.AdMob
{
	public class UnityAdsService : IAdsService
	{
		private string gameId;

		private bool testMode;

		private string placementId;

		private Action<RewardVideoResult> callBack;

		public UnityAdsService(string gameId, string placementId, bool testMode)
		{
		}

		public void RequestRewardVideo()
		{
		}

		public void ShowRewardVideo(Action<RewardVideoResult> callBack)
		{
		}

		public void Initialize()
		{
		}

		public bool IsRewardVideoAlready()
		{
			return false;
		}

		private void InvokeCallBack(RewardVideoResult rewardVideoResult)
		{
		}
	}
}
