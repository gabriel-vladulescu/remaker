using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class FlashSaleOreRuneBundleCountdown : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCountdownRoutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FlashSaleOreRuneBundleCountdown _003C_003E4__this;

			private DateTime _003CendTime_003E5__2;

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
			public _003CCountdownRoutine_003Ed__6(int _003C_003E1__state)
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

		public UILabel lb_endTime;

		public bool useLongTimeFormat;

		private const string SHORT_TIME_FORMAT = "{0}:{1}:{2}";

		private const string LONG_TIME_FORMAT = "Offer Ends In: {0} Hours {1} Mins {2} Secs";

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[IteratorStateMachine(typeof(_003CCountdownRoutine_003Ed__6))]
		private IEnumerator CountdownRoutine()
		{
			return null;
		}
	}
}
