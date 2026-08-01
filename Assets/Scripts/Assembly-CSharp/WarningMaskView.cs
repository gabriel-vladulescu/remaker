using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using strange.extensions.mediation.impl;

public class WarningMaskView : View
{
	[CompilerGenerated]
	private sealed class _003CActivateScale_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WarningMaskView _003C_003E4__this;

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
		public _003CActivateScale_003Ed__24(int _003C_003E1__state)
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

	private const string COLOR_KEY = "_MainColor";

	public Renderer rend;

	public AnimationCurve curve;

	public float duration;

	public float loopCircle;

	public float loopAlpha;

	private Material mat;

	private float prevPercent;

	private float curTime;

	private bool isPlaying;

	private bool isLooping;

	private Color c;

	private const float HP_THRESHOLD = 0.3f;

	private bool enable;

	internal void Init()
	{
	}

	internal void SetEnable(bool enable)
	{
	}

	internal void Play(float percent)
	{
	}

	private void Stop()
	{
	}

	private void ActivateLoop()
	{
	}

	private void DeactivateLoop()
	{
	}

	private void SetActive(bool value)
	{
	}

	private void Update()
	{
	}

	private void Process(float dur, float factor = 1f)
	{
	}

	private void Scale()
	{
	}

	[IteratorStateMachine(typeof(_003CActivateScale_003Ed__24))]
	private IEnumerator ActivateScale()
	{
		return null;
	}
}
