using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UniWebView : MonoBehaviour
{
	public delegate void LoadCompleteDelegate(UniWebView webView, bool success, string errorMessage);

	public delegate void LoadBeginDelegate(UniWebView webView, string loadingUrl);

	public delegate void ReceivedMessageDelegate(UniWebView webView, UniWebViewMessage message);

	public delegate void EvalJavaScriptFinishedDelegate(UniWebView webView, string result);

	public delegate bool WebViewShouldCloseDelegate(UniWebView webView);

	public delegate void ReceivedKeyCodeDelegate(UniWebView webView, int keyCode);

	public delegate UniWebViewEdgeInsets InsetsForScreenOreitationDelegate(UniWebView webView, UniWebViewOrientation orientation);

	[CompilerGenerated]
	private sealed class _003CLoadFromJarPackage_003Ed__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string jarFilePath;

		public UniWebView _003C_003E4__this;

		private WWW _003Cstream_003E5__2;

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
		public _003CLoadFromJarPackage_003Ed__105(int _003C_003E1__state)
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

	[SerializeField]
	private UniWebViewEdgeInsets _insets;

	public string url;

	public bool loadOnStart;

	public bool autoShowWhenLoadComplete;

	private bool _backButtonEnable;

	private bool _bouncesEnable;

	private bool _zoomEnable;

	private string _currentGUID;

	private int _lastScreenHeight;

	private bool _immersiveMode;

	private Action _showTransitionAction;

	private Action _hideTransitionAction;

	public bool toolBarShow;

	public UniWebViewEdgeInsets insets
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string currentUrl => null;

	public bool backButtonEnable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool bouncesEnable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool zoomEnable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string userAgent => null;

	public float alpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool immersiveMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public event LoadCompleteDelegate OnLoadComplete;

	public event LoadBeginDelegate OnLoadBegin;

	public event ReceivedMessageDelegate OnReceivedMessage;

	public event EvalJavaScriptFinishedDelegate OnEvalJavaScriptFinished;

	public event WebViewShouldCloseDelegate OnWebViewShouldClose;

	public event ReceivedKeyCodeDelegate OnReceivedKeyCode;

	public event InsetsForScreenOreitationDelegate InsetsForScreenOreitation;

	private void ForceUpdateInsetsInternal(UniWebViewEdgeInsets insets)
	{
	}

	public static void SetUserAgent(string value)
	{
	}

	public static void ResetUserAgent()
	{
	}

	public void Load()
	{
	}

	public void Load(string aUrl)
	{
	}

	public void LoadHTMLString(string htmlString, string baseUrl)
	{
	}

	public void Reload()
	{
	}

	public void Stop()
	{
	}

	public void Show(bool fade = false, UniWebViewTransitionEdge direction = UniWebViewTransitionEdge.None, float duration = 0.4f, Action finishAction = null)
	{
	}

	public void Hide(bool fade = false, UniWebViewTransitionEdge direction = UniWebViewTransitionEdge.None, float duration = 0.4f, Action finishAction = null)
	{
	}

	public void EvaluatingJavaScript(string javaScript)
	{
	}

	public void AddJavaScript(string javaScript)
	{
	}

	public void CleanCache()
	{
	}

	public void CleanCookie(string key = null)
	{
	}

	[Obsolete("SetTransparentBackground is deprecated, please use SetBackgroundColor instead.")]
	public void SetTransparentBackground(bool transparent = true)
	{
	}

	public void SetBackgroundColor(Color color)
	{
	}

	public void ShowToolBar(bool animate)
	{
	}

	public void HideToolBar(bool animate)
	{
	}

	public void SetShowSpinnerWhenLoading(bool show)
	{
	}

	public void SetSpinnerLabelText(string text)
	{
	}

	public void SetUseWideViewPort(bool use)
	{
	}

	public bool CanGoBack()
	{
		return false;
	}

	public bool CanGoForward()
	{
		return false;
	}

	public void GoBack()
	{
	}

	public void GoForward()
	{
	}

	public void AddPermissionRequestTrustSite(string url)
	{
	}

	public void AddUrlScheme(string scheme)
	{
	}

	public void RemoveUrlScheme(string scheme)
	{
	}

	public void SetHeaderField(string key, string value)
	{
	}

	public void SetVerticalScrollBarShow(bool show)
	{
	}

	public void SetHorizontalScrollBarShow(bool show)
	{
	}

	private bool OrientationChanged()
	{
		return false;
	}

	private void ResizeInternal()
	{
	}

	private void LoadComplete(string message)
	{
	}

	private void LoadBegin(string url)
	{
	}

	private void ReceivedMessage(string rawMessage)
	{
	}

	private void WebViewDone(string message)
	{
	}

	private void WebViewKeyDown(string message)
	{
	}

	private void EvalJavaScriptFinished(string result)
	{
	}

	private void AnimationFinished(string identifier)
	{
	}

	private void ShowTransitionFinished(string message)
	{
	}

	private void HideTransitionFinished(string message)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadFromJarPackage_003Ed__105))]
	private IEnumerator LoadFromJarPackage(string jarFilePath)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void RemoveAllListeners()
	{
	}

	private void Update()
	{
	}
}
