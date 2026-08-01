using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ssar.Rune.Model;
using strange.extensions.command.impl;

namespace Ssar.Rune
{
	public class CombineRuneCmd : Command
	{
		[CompilerGenerated]
		private sealed class _003CPlayFx_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CombineRuneCmd _003C_003E4__this;

			public Ssar.Rune.Model.Rune rune;

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
			public _003CPlayFx_003Ed__17(int _003C_003E1__state)
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
		public RuneType RuneType { get; set; }

		[Inject]
		public RuneRarity RuneRarity { get; set; }

		[Inject]
		public int amount { get; set; }

		[Inject]
		public OnCombineRuneSuccessSignal OnCombineRuneSuccessSignal { get; set; }

		public override void Execute()
		{
		}

		[IteratorStateMachine(typeof(_003CPlayFx_003Ed__17))]
		private IEnumerator PlayFx(Ssar.Rune.Model.Rune rune)
		{
			return null;
		}
	}
}
