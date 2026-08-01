using System;
using Assets.Scripts.Ssar.AdMob;

public class VungleAdsService : IAdsService
{
	private string appId;

	private string placementId;

	private Action<RewardVideoResult> m_callBack;

	public VungleAdsService(string appId, string placementId)
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
}
