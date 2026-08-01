using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Firebase;
using Scripts.Config;
using strange.extensions.command.impl;

namespace Ssar.Database
{
	public class InitFirebaseDatabaseCommand : Command
	{
		public class FirebaseAvailability
		{
			private bool available;

			public FirebaseAvailability(bool available)
			{
			}

			public bool IsAvailable()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CDelayFrame_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InitFirebaseDatabaseCommand _003C_003E4__this;

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
			public _003CDelayFrame_003Ed__5(int _003C_003E1__state)
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

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayFrame_003Ed__5))]
		private IEnumerator DelayFrame()
		{
			return null;
		}

		private bool TryInitFirebase()
		{
			return false;
		}

		private bool InitFirebaseAfterFixingDependencies(DependencyStatus dependencyStatus)
		{
			return false;
		}

		private void SetFirebaseAvailability(bool available)
		{
		}

		private void InitializeFirebase()
		{
		}

		private void AuthOnStateChanged(object sender, EventArgs eventArgs)
		{
		}
	}
}
