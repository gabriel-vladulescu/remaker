using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using strange.extensions.mediation.impl;

public abstract class BasePopup : View
{
	[CompilerGenerated]
	private sealed class _003CDelayActive_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BasePopup _003C_003E4__this;

		private bool _003Cdelay_003E5__2;

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
		public _003CDelayActive_003Ed__12(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CDelayEnableListenBack_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BasePopup _003C_003E4__this;

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
		public _003CDelayEnableListenBack_003Ed__26(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CDelaySetPanel_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BasePopup _003C_003E4__this;

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
		public _003CDelaySetPanel_003Ed__18(int _003C_003E1__state)
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

	public bool smoothTween;

	public AnimationCurve animationCurve;

	private UIPanel panel;

	private TweenScale tween;

	private int cacheLayer;

	private bool firstTime;

	private bool enableListenBack;

	private bool hideByOpenAnotherPopup;

	private static readonly HashSet<int> tutorialIdsWhitelist;

	protected override void Start()
	{
	}

	protected new virtual void Awake()
	{
	}

	protected new virtual void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayActive_003Ed__12))]
	private IEnumerator DelayActive()
	{
		return null;
	}

	public virtual void UIResetDelay(float time)
	{
	}

	private void UIReset()
	{
	}

	protected new virtual void OnDisable()
	{
	}

	protected new virtual void OnDestroy()
	{
	}

	protected virtual void onEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CDelaySetPanel_003Ed__18))]
	private IEnumerator DelaySetPanel()
	{
		return null;
	}

	protected virtual void BackPopup(GameObject o)
	{
	}

	public virtual void Hide()
	{
	}

	public void Hide(GameObject o)
	{
	}

	protected void OnListenBack()
	{
	}

	protected virtual void ExecuteBack()
	{
	}

	protected bool CanBack()
	{
		return false;
	}

	protected abstract bool EnableBack();

	[IteratorStateMachine(typeof(_003CDelayEnableListenBack_003Ed__26))]
	private IEnumerator DelayEnableListenBack()
	{
		return null;
	}

	public virtual bool AddToListShow()
	{
		return false;
	}

	protected void HideByOpenAnotherPopup()
	{
	}
}
