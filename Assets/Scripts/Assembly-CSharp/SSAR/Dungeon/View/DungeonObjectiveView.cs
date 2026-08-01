using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SSAR.Dungeon.Model;
using strange.extensions.mediation.impl;

namespace SSAR.Dungeon.View
{
	public class DungeonObjectiveView : strange.extensions.mediation.impl.View
	{
		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DungeonObjectiveView _003C_003E4__this;

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
			public _003CDelay_003Ed__8(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CReposition_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DungeonObjectiveView _003C_003E4__this;

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
			public _003CReposition_003Ed__7(int _003C_003E1__state)
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

		public UITable table;

		public UISprite bg;

		public UIWidget wgEffect;

		private DungeonObjectiveItemView[] objectiveItemViews;

		private bool firstTime;

		protected override void Awake()
		{
		}

		public void EnterStage(List<DungeonObjectiveManager.StageGoal> goals)
		{
		}

		[IteratorStateMachine(typeof(_003CReposition_003Ed__7))]
		private IEnumerator Reposition()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__8))]
		private IEnumerator Delay()
		{
			return null;
		}

		public void Hide()
		{
		}
	}
}
