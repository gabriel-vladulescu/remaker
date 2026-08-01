using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Dungeon.Signal;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class MainCharacterDeathCmd : strange.extensions.command.impl.Command
	{
		[CompilerGenerated]
		private sealed class _003CEffect_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MainCharacterDeathCmd _003C_003E4__this;

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
			public _003CEffect_003Ed__17(int _003C_003E1__state)
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
		private sealed class _003CSlowMotion_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CharacterDeathEffectEditor characterDeathEffectEditor;

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
			public _003CSlowMotion_003Ed__18(int _003C_003E1__state)
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
		public CheckDungeonCanResurrectionSignal CheckDungeonCanResurrectionSignal { get; set; }

		[Inject]
		public ShowdDungeonResurrectionPopupSignal ShowdDungeonResurrectionPopupSignal { get; set; }

		[Inject]
		public SetEnableWarningMaskSignal SetEnableWarningMaskSignal { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		[IteratorStateMachine(typeof(_003CEffect_003Ed__17))]
		private IEnumerator Effect()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSlowMotion_003Ed__18))]
		private IEnumerator SlowMotion(CharacterDeathEffectEditor characterDeathEffectEditor)
		{
			return null;
		}
	}
}
