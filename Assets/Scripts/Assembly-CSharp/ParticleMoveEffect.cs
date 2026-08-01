using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ParticleMoveEffect : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDelayPlay_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ParticleMoveEffect _003C_003E4__this;

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
		public _003CDelayPlay_003Ed__11(int _003C_003E1__state)
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

	public float duration;

	public bool loop;

	public TweenPosition tweenPosition;

	public GameObject particle;

	public UIWidget[] point;

	private bool isPlay;

	private int index;

	private float distance;

	private int count;

	public void Play()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayPlay_003Ed__11))]
	private IEnumerator DelayPlay()
	{
		return null;
	}

	private void Tween()
	{
	}

	private void Update()
	{
	}

	public void Stop()
	{
	}
}
