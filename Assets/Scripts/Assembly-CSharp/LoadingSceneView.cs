using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.SceneLoader.View;
using UnityEngine;

public class LoadingSceneView : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCountdown_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		public Action<float> tick;

		private float _003Cdelta_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CCountdown_003Ed__35(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public UILabel lb_tip;

	public UILabel lb_title;

	public UILabel interstitialCountdownLabel;

	public UILabel lb_adsCountdownProgress;

	public UIProgressBar ProgressBar;

	public UIProgressBar adsCountdownProgresssBar;

	public UILabel text;

	public UITexture bg;

	public GameObject camera3d;

	public GameObject container;

	public GameObject container3d;

	public GameObject modelRoot;

	public GameObject staticContainer;

	public GameObject titleContainer;

	public int groupId;

	public bool enableRandom;

	public bool enableTest;

	private LoadingSceneCharacterControl loadingSceneCharacter;

	private bool interstitialAdsEnable;

	private bool isFinishAds;

	public LoadingModeType LoadingModeType { get; set; }

	private void Awake()
	{
	}

	public void ForceDestroy()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	public bool IsFinishAds()
	{
		return false;
	}

	public void Active(LoadingSceneType loadingSceneType, LoadingModeType loadingModeType)
	{
	}

	public void EnableInterstitialAds()
	{
	}

	public void CountdownToShowInterstitialAds()
	{
	}

	private void SendMetricIntersAdsShow()
	{
	}

	public void PauseDefaultProgressBar()
	{
	}

	public void ContinueDefaultProgressBar()
	{
	}

	[IteratorStateMachine(typeof(_003CCountdown_003Ed__35))]
	private IEnumerator Countdown(float seconds, Action<float> tick)
	{
		return null;
	}

	public void EnableTip()
	{
	}

	public void UpdateProgressBar(float progress)
	{
	}

	private void OnGUI()
	{
	}

	private void InitTest()
	{
	}
}
