using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using strange.extensions.command.impl;

namespace Ssar.RemoteConfig.Command
{
	public class InitFirebaseRemoteConfigCmd : strange.extensions.command.impl.Command
	{
		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InitFirebaseRemoteConfigCmd _003C_003E4__this;

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
			public _003CDelay_003Ed__4(int _003C_003E1__state)
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

		public override void Execute()
		{
		}

		private void SetDefaultConfig()
		{
		}

		private void FetchConfig()
		{
		}

		private void ActivateRetrievedRemoteConfig()
		{
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__4))]
		private IEnumerator Delay()
		{
			return null;
		}
	}
}
