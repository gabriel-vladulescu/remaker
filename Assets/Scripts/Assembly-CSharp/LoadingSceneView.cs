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

	// Interstitial-ads fields/methods below (interstitialAdsEnable,
	// EnableInterstitialAds, CountdownToShowInterstitialAds,
	// SendMetricIntersAdsShow, adsCountdownProgresssBar,
	// interstitialCountdownLabel) are intentionally left as no-ops - not
	// reconnecting real ad SDKs, consistent with the rest of this project.
	private bool progressBarPaused;

	private void Awake()
	{
	}

	public void ForceDestroy()
	{
		Destroy(gameObject);
	}

	private void OnDestroy()
	{
	}

	// Self-contained default so opening LoadingScene.unity directly (e.g.
	// for testing) still boots into Main, not just when reached via the
	// real Title -> Loading -> Main flow.
	private void OnEnable()
	{
		Active(LoadingSceneType.NoneDisplay, LoadingModeType.Normal);
	}

	public bool IsFinishAds()
	{
		return true;
	}

	public void Active(LoadingSceneType loadingSceneType, LoadingModeType loadingModeType)
	{
		LoadingModeType = loadingModeType;

		bool showModel = loadingSceneType == LoadingSceneType.Model;
		bool showStatic = loadingSceneType == LoadingSceneType.Static;

		if (container3d != null)
		{
			NGUITools.SetActive(container3d, showModel);
		}
		if (staticContainer != null)
		{
			NGUITools.SetActive(staticContainer, showStatic);
		}
		if (titleContainer != null)
		{
			NGUITools.SetActive(titleContainer, true);
		}

		UpdateProgressBar(0f);
		StartCoroutine(BootSequence());
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
		progressBarPaused = true;
	}

	public void ContinueDefaultProgressBar()
	{
		progressBarPaused = false;
	}

	// The real game presumably preloads assets/config here; there's nothing
	// left to preload in this reimplementation (everything's already in the
	// one Unity project), so this is a fixed-duration simulated progress bar
	// purely so the loading screen doesn't just flash and vanish.
	private const float BootDurationSeconds = 1.5f;

	// Real tip content pulled from Resources/config/LoadingTipConfig.json ->
	// I2Languages.asset (LOADING_TIP_1..30). Most of those 30 terms have no
	// actual text in any language (looks unfinished/unused on the original
	// devs' end) - these 4 are the ones that do. Full I2 Localization
	// wiring (LocalizationManager, language selection, etc.) is its own
	// separate task and not reimplemented; these are just the English
	// strings, hardcoded.
	private static readonly string[] Tips =
	{
		"Tips: Unlocking Dash Attack combo enables you to immediately perform a swift attack after dashing.",
		"Tips: Unlocking Strike Down combo enables you to perform a powerful slam finisher after executing aerial attack.",
		"Tips: You can save and load data in the settings menu.",
		"Tips: Quinn can perform Raven Wings in mid-air."
	};

	private IEnumerator BootSequence()
	{
		if (lb_tip != null)
		{
			lb_tip.text = Tips[UnityEngine.Random.Range(0, Tips.Length)];
		}
		EnableTip();

		yield return Countdown(BootDurationSeconds, delegate(float elapsed)
		{
			UpdateProgressBar(Mathf.Clamp01(elapsed / BootDurationSeconds));
		});

		UpdateProgressBar(1f);

		// LoadingScene's real place in the flow is between Title (after
		// login) and Main - see GameInitController.LoadSceneStart's comment.
		UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
	}

	[IteratorStateMachine(typeof(_003CCountdown_003Ed__35))]
	private IEnumerator Countdown(float seconds, Action<float> tick)
	{
		float elapsed = 0f;
		while (elapsed < seconds)
		{
			while (progressBarPaused)
			{
				yield return null;
			}
			elapsed += Time.deltaTime;
			tick?.Invoke(Mathf.Min(elapsed, seconds));
			yield return null;
		}
	}

	public void EnableTip()
	{
		if (lb_tip != null)
		{
			NGUITools.SetActive(lb_tip.gameObject, true);
		}
	}

	public void UpdateProgressBar(float progress)
	{
		if (ProgressBar != null)
		{
			ProgressBar.value = progress;
		}
	}

	private void OnGUI()
	{
	}

	private void InitTest()
	{
	}
}
