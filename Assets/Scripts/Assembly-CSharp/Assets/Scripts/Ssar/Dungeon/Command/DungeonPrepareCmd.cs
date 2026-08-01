using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Artemis;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class DungeonPrepareCmd : strange.extensions.command.impl.Command
	{
		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DungeonPrepareCmd _003C_003E4__this;

			private EntityWorld _003CentityWorld_003E5__2;

			private DungeonSystem _003CdungeonSystem_003E5__3;

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
			public _003CDelay_003Ed__13(int _003C_003E1__state)
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
		public IBattleModeLogic BattleModeLogic { get; set; }

		[Inject]
		public Action finish { get; set; }

		[Inject]
		public DisableInputAndAISignal StopAllAiSignal { get; set; }

		public override void Execute()
		{
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__13))]
		private IEnumerator Delay()
		{
			return null;
		}
	}
}
