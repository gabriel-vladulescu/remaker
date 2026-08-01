using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class ShopTreasureChestFxPopup : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCheckFinish_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShopTreasureChestFxPopup _003C_003E4__this;

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
			public _003CCheckFinish_003Ed__4(int _003C_003E1__state)
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

		public Animation Animation;

		public PlayEffectByFrame PlayEffectByFrame;

		public Action onFinish;

		public void Show(Action onFinish)
		{
		}

		[IteratorStateMachine(typeof(_003CCheckFinish_003Ed__4))]
		private IEnumerator CheckFinish()
		{
			return null;
		}

		public void Hide()
		{
		}
	}
}
