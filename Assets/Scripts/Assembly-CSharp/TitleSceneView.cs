using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SSAR.View;
using UnityEngine;

public class TitleSceneView : BasePopup
{
	[CompilerGenerated]
	private sealed class _003CDelay_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TitleSceneView _003C_003E4__this;

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
		public _003CDelay_003Ed__22(int _003C_003E1__state)
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

	public GameObject clickArea;

	public UILabel lb_text;

	public TweenAlpha TweenAlpha;

	public GameObject wg_loginMethod;

	public GameObject btn_loginGuest;

	public GameObject btn_loginGoogle;

	public GameObject btn_loginFacebook;

	public GameObject btn_setting;

	private bool finishInit;

	private string textLoading;

	private TextLoading textLoadingControl;

	private bool hasStartTapToplay;

	private TitleSceneProgressbarView progressbarView;

	private bool enableAutoUpdateText;

	private float time;

	protected new void Awake()
	{
		base.Awake();
	}

	private void ClickBack()
	{
		OnListenBack();
	}

	private void InstantiateBar()
	{
	}

	// Real Google/Facebook OAuth login is not reimplemented here (no
	// backend to authenticate against) - only Guest login actually
	// proceeds. Awake/Start-time flow: show "tap to play", tapping reveals
	// the login choices, Guest is the only one wired to LoginSuccess.
	protected override void OnEnable()
	{
		base.OnEnable();
		finishInit = true;
		EnableWgLogin(false);
		EnableTapToPlay(true);

		if (clickArea != null)
		{
			UIEventListener.Get(clickArea).onClick -= OnClickAreaClicked;
			UIEventListener.Get(clickArea).onClick += OnClickAreaClicked;
		}
		if (btn_loginGuest != null)
		{
			UIEventListener.Get(btn_loginGuest).onClick -= LoginGuest;
			UIEventListener.Get(btn_loginGuest).onClick += LoginGuest;
		}
		if (btn_loginGoogle != null)
		{
			UIEventListener.Get(btn_loginGoogle).onClick -= LoginGoogle;
			UIEventListener.Get(btn_loginGoogle).onClick += LoginGoogle;
		}
		if (btn_loginFacebook != null)
		{
			UIEventListener.Get(btn_loginFacebook).onClick -= LoginFacebook;
			UIEventListener.Get(btn_loginFacebook).onClick += LoginFacebook;
		}
	}

	private void OnClickAreaClicked(GameObject o)
	{
		if (!hasStartTapToplay)
		{
			return;
		}
		hasStartTapToplay = false;
		EnableTapToPlay(false);
		EnableWgLogin(true);
	}

	protected override void OnDestroy()
	{
		base.OnDestroy();
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void ExecuteBack()
	{
	}

	[IteratorStateMachine(typeof(_003CDelay_003Ed__22))]
	private IEnumerator Delay()
	{
		return null;
	}

	private void Update()
	{
	}

	// Goes through LoadingScene rather than straight to Main - see
	// GameInitController.LoadSceneStart's comment for why LoadingScene
	// belongs here, not between Entry and Title.
	private void GoToMain(GameObject o)
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene("LoadingScene");
	}

	private void FinishInit()
	{
	}

	private void FinishDownload()
	{
	}

	private void FinishPrepare()
	{
	}

	private void EnableTapToPlay(bool enable)
	{
		hasStartTapToplay = enable;
		if (clickArea != null)
		{
			NGUITools.SetActive(clickArea, enable);
		}
		if (lb_text != null)
		{
			NGUITools.SetActive(lb_text.gameObject, enable);
		}

		if (TweenAlpha != null)
		{
			if (enable)
			{
				TweenAlpha.style = UITweener.Style.PingPong;
				TweenAlpha.method = UITweener.Method.EaseInOut;
				TweenAlpha.from = 0.3f;
				TweenAlpha.to = 1f;
				TweenAlpha.duration = 1f;
				TweenAlpha.enabled = true;
				TweenAlpha.ResetToBeginning();
				TweenAlpha.PlayForward();
			}
			else
			{
				TweenAlpha.enabled = false;
			}
		}
	}

	private void EnableWgLogin(bool enable)
	{
		if (wg_loginMethod != null)
		{
			NGUITools.SetActive(wg_loginMethod, enable);
		}
	}

	private void LoginError(string msg)
	{
		UnityEngine.Debug.LogError("[TitleSceneView] Login error: " + msg);
		EnableWgLogin(true);
	}

	private void LoginSuccess()
	{
		EnableWgLogin(false);
		GoToMain(null);
	}

	public void Relogin(GameObject o)
	{
		EnableWgLogin(true);
	}

	private void Init()
	{
	}

	private void LoginGuest(GameObject o)
	{
		LoginSuccess();
	}

	private void LoginFacebook(GameObject o)
	{
		LoginError("Facebook login is not available in this build.");
	}

	private void LoginGoogle(GameObject o)
	{
		LoginError("Google login is not available in this build.");
	}
}
