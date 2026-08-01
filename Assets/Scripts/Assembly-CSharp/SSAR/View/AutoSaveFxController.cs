using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SSAR.View
{
	public class AutoSaveFxController
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AutoSaveFxController _003C_003E4__this;

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
			public _003CStart_003Ed__8(int _003C_003E1__state)
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

		private bool isPlay;

		private TweenFill texture;

		private GameObject container;

		private TweenAlpha tweenAlpha;

		private float time;

		public AutoSaveFxController(GameObject container, TweenFill texture, TweenAlpha tweenAlpha)
		{
		}

		public void Hide()
		{
		}

		public void Excute()
		{
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__8))]
		private IEnumerator Start()
		{
			return null;
		}
	}
}
