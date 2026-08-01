using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ssar.RaidBoss.Model;
using strange.extensions.mediation.impl;

namespace Ssar.RaidBoss.View
{
	public class RaidSeasonTimeLeftMediator : Mediator
	{
		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RaidSeasonTimeLeftMediator _003C_003E4__this;

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
			public _003CDelay_003Ed__20(int _003C_003E1__state)
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
		public RaidSeasonTimeLeftView view { get; set; }

		[Inject]
		public OnUpdateRaidSeasonEndTimeSuccessSignal OnUpdateRaidSeasonEndTimeSuccessSignal { get; set; }

		[Inject]
		public UpdateRaidTimeLeftViewSignal UpdateRaidTimeLeftViewSignal { get; set; }

		[Inject]
		public UpdateRaidSeasonEndTimeSignal UpdateRaidSeasonEndTimeSignal { get; set; }

		public override void OnEnabled()
		{
		}

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		private void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__20))]
		private IEnumerator Delay()
		{
			return null;
		}
	}
}
