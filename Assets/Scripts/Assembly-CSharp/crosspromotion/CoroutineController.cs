using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace crosspromotion
{
	public class CoroutineController
	{
		public delegate void OnFinish(CoroutineController coroutineController);

		[CompilerGenerated]
		private sealed class _003CStart_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CoroutineController _003C_003E4__this;

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
			public _003CStart_003Ed__10(int _003C_003E1__state)
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

		public bool canStopWhenClearScene;

		private IEnumerator _routine;

		private Coroutine _coroutine;

		private CoroutineState _state;

		public CoroutineState state => default(CoroutineState);

		public Coroutine coroutine => null;

		public IEnumerator routine => null;

		public event OnFinish onFinish;

		public CoroutineController(IEnumerator routine, bool canStopWhenClearScene)
		{
		}

		public void StartCoroutine(MonoBehaviour monoBehaviour)
		{
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__10))]
		public IEnumerator Start()
		{
			return null;
		}

		public void Stop()
		{
		}

		public void Pause()
		{
		}

		public void Resume()
		{
		}
	}
}
