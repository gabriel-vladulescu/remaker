using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Common.Pooling;

namespace Ssar.BattleSystem.EntityTemplate
{
	public class MonsterGameObjectItem : GameObjectItem
	{
		[CompilerGenerated]
		private sealed class _003CWait_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CWait_003Ed__5(int _003C_003E1__state)
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

		private Action undoAction;

		private int recycledCount;

		public void SetUndoAction(Action action)
		{
		}

		public override void OnObtain()
		{
		}

		public override void OnReturn()
		{
		}

		[IteratorStateMachine(typeof(_003CWait_003Ed__5))]
		private IEnumerator Wait()
		{
			return null;
		}

		public void OnRecycled()
		{
		}

		public bool IsRecycled()
		{
			return false;
		}
	}
}
