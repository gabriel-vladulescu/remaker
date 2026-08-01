using System;
using System.Collections.Generic;
using Assets.Scripts.Ssar.AdMob;
using UnityEngine;

public class AdController : MonoBehaviour
{
	private static AdController adController;

	public bool testMode;

	[Header("Iron source")]
	public string ironSourceAppKey;

	private List<IAdsService> adsServices;

	private IronSourceAdsService ironsourceAdsService;

	private float ironSourceAdsHitRate;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public static AdController Instantiate()
	{
		return null;
	}

	public void RequestVideoReward()
	{
	}

	public bool IsVideoRewardAlready()
	{
		return false;
	}

	public void ShowVideoReward(Action<RewardVideoResult> handler)
	{
	}

	public void AdjustIronSourceVideoRewardHitRate(float newRate)
	{
	}

	private void Initialize()
	{
	}

	private IAdsService GetServiceVideoRewardAlready()
	{
		return null;
	}
}
