using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.View
{
	public class DuelArenaStartWarningContainer : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public Action onFinish;

			internal void _003CDelay_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action onFinish;

			public DuelArenaStartWarningContainer _003C_003E4__this;

			private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

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
			public _003CDelay_003Ed__3(int _003C_003E1__state)
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

		public UIPlayTween playTween;

		public float hold;

		public void Play(Action onFinish)
		{
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__3))]
		private IEnumerator Delay(Action onFinish)
		{
			return null;
		}
	}
}
