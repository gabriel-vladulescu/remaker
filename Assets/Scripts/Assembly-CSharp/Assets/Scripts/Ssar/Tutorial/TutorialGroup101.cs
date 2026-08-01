using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Assets.Scripts.Ssar.Tutorial
{
	public class TutorialGroup101 : ITutorialGroup
	{
		[CompilerGenerated]
		private sealed class _003CDelayReenable_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CDelayReenable_003Ed__2(int _003C_003E1__state)
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

		public override bool IsComplete => false;

		public TutorialGroup101(string name, MainCharacterData mainCharacterData)
			: base(null, null)
		{
		}

		private void OnStart()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayReenable_003Ed__2))]
		private IEnumerator DelayReenable()
		{
			return null;
		}

		public override bool IsErrorData()
		{
			return false;
		}

		public override bool IsCanInterrupt()
		{
			return false;
		}

		public override bool IsAlwayCheckError()
		{
			return false;
		}
	}
}
