using System;

namespace Assets.Scripts.Ssar.AdMob
{
	public interface IAdsService
	{
		void Initialize();

		void RequestRewardVideo();

		bool IsRewardVideoAlready();

		void ShowRewardVideo(Action<RewardVideoResult> callBack);
	}
}
