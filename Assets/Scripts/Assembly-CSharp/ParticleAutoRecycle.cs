using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ParticleAutoRecycle : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCheckIfAlive_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ParticleAutoRecycle _003C_003E4__this;

		private bool _003CisCheck_003E5__2;

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
		public _003CCheckIfAlive_003Ed__6(int _003C_003E1__state)
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

	private bool isAlive;

	private ParticleSystem[] particle;

	public bool isScaled;

	private float scaleFactor;

	private List<float> initParticleScale;

	protected virtual void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CCheckIfAlive_003Ed__6))]
	private IEnumerator CheckIfAlive()
	{
		return null;
	}

	private void GetParticle()
	{
	}

	public void ScaleEffect(float scaleFactor)
	{
	}

	public virtual void OnExit()
	{
	}

	private void OnDisable()
	{
	}

	private void DescaleEffect()
	{
	}
}
