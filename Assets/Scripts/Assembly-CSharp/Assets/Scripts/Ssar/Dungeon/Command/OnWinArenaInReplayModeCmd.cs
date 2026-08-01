using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic.Arena;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class OnWinArenaInReplayModeCmd : strange.extensions.command.impl.Command
	{
		[CompilerGenerated]
		private sealed class _003CShowPopup_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ArenaResultData arenaWinData;

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
			public _003CShowPopup_003Ed__7(int _003C_003E1__state)
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
		public ArenaModeParameter Parameter { get; set; }

		public override void Execute()
		{
		}

		private void PlayAnimation()
		{
		}

		private void Popup(ArenaResultData arenaWinData)
		{
		}

		[IteratorStateMachine(typeof(_003CShowPopup_003Ed__7))]
		private IEnumerator ShowPopup(ArenaResultData arenaWinData)
		{
			return null;
		}
	}
}
