using System;
using System.Collections.Generic;
using GoogleMobileAds.Ump.Api;
using UnityEngine;

public class UMPManager : Z_Singleton<UMPManager>
{
	[SerializeField]
	private bool _isDebug;

	[SerializeField]
	private List<string> _testDeviceIds;

	private Action _callback;

	private Action _pauseFunc;

	private Action _resumeFunc;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void InitUMP(Action callback = null, Action pauseFunc = null, Action resumeFunc = null)
	{
	}

	private void Init()
	{
	}

	private void OnConsentInfoUpdated(FormError consentError)
	{
	}

	private void PauseGame()
	{
	}

	private void ResumeGame()
	{
	}
}
