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
	}

	private void ClickBack()
	{
	}

	private void InstantiateBar()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDestroy()
	{
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

	private void GoToMain(GameObject o)
	{
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
	}

	private void EnableWgLogin(bool enable)
	{
	}

	private void LoginError(string msg)
	{
	}

	private void LoginSuccess()
	{
	}

	public void Relogin(GameObject o)
	{
	}

	private void Init()
	{
	}

	private void LoginGuest(GameObject o)
	{
	}

	private void LoginFacebook(GameObject o)
	{
	}

	private void LoginGoogle(GameObject o)
	{
	}
}
