using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Artemis;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.Signal;
using SSAR.BattleSystem.Movement;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using UnityEngine;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class MainCharacterResurrectionSuccessCmd : strange.extensions.command.impl.Command
	{
		[CompilerGenerated]
		private sealed class _003CExplosion_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MainCharacterResurrectionSuccessCmd _003C_003E4__this;

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
			public _003CExplosion_003Ed__28(int _003C_003E1__state)
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
		private sealed class _003CPlaySound_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float time;

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
			public _003CPlaySound_003Ed__29(int _003C_003E1__state)
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
		private sealed class _003CSequence_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MainCharacterResurrectionSuccessCmd _003C_003E4__this;

			private EntityWorld _003CentityWorld_003E5__2;

			private Entity _003Cmain_003E5__3;

			private Dungeon _003Cdungeon_003E5__4;

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
			public _003CSequence_003Ed__27(int _003C_003E1__state)
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

		private float distanceBeKnockback;

		[Inject]
		public DisableInputAndAISignal DisableInputAndAiSignal { get; set; }

		[Inject]
		public SetEnableWarningMaskSignal SetEnableWarningMaskSignal { get; set; }

		[Inject]
		public UpdateMainCharacterHealthSignal UpdateMainCharacterHealthSignal { get; set; }

		[Inject]
		public IBattleModeLogic battleModeLogic { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private void SendResurrectionMetric()
		{
		}

		[IteratorStateMachine(typeof(_003CSequence_003Ed__27))]
		private IEnumerator Sequence()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CExplosion_003Ed__28))]
		private IEnumerator Explosion()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPlaySound_003Ed__29))]
		private IEnumerator PlaySound(float time)
		{
			return null;
		}

		private void KnockBackMonster()
		{
		}

		private bool IsAvailableToKnockBack(Vector3 center, Entity target, ref float disatanceX, ref Direction direction)
		{
			return false;
		}

		private void EnableUI()
		{
		}
	}
}
