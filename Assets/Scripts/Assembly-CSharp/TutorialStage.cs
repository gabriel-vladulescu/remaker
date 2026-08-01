using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TutorialStage
{
	public delegate void OnProcessDelegate(TutorialKey key, TutorialStage stage);

	public delegate void OnStartDelegate();

	[CompilerGenerated]
	private sealed class _003CDelay_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialStage _003C_003E4__this;

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
		public _003CDelay_003Ed__18(int _003C_003E1__state)
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

	public TutorialKey key;

	public bool isNecessary;

	public ITutParameter parameter;

	public TutDisableWhenComplete disableWhenComplete;

	private GameObject view;

	private string groupName;

	public bool IsComplete { get; protected set; }

	private event OnProcessDelegate onProcessDelegate;

	private event OnStartDelegate onStartDelegate;

	public TutorialStage(TutorialKey key, ITutParameter parameter, bool isNecessary, OnStartDelegate onStart, OnProcessDelegate onProcess, TutDisableWhenComplete disableWhenComplete = TutDisableWhenComplete.ENABLE)
	{
	}

	public void SetGroup(string groupName)
	{
	}

	public void Active()
	{
	}

	public void SilenceActive()
	{
	}

	[IteratorStateMachine(typeof(_003CDelay_003Ed__18))]
	private IEnumerator Delay()
	{
		return null;
	}

	public virtual void OnComplete()
	{
	}

	public void HideTutorial()
	{
	}

	public void SilenceComplete()
	{
	}

	public void SetComplete()
	{
	}

	public void Reset()
	{
	}
}
