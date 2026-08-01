using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Artemis;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.Signal;
using SSAR.Dungeon.Model;
using UnityEngine;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class ShowDungeonWinEffectCmd : strange.extensions.command.impl.Command
	{
		[CompilerGenerated]
		private sealed class _003CEffect_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShowDungeonWinEffectCmd _003C_003E4__this;

			public DungeonWinParameter parameter;

			private DungeonWinEffectEditor _003CdungeonWinEffectEditor_003E5__2;

			private DungeonDataManager _003CdungeonDataManager_003E5__3;

			private Entity _003Cmain_003E5__4;

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
			public _003CEffect_003Ed__21(int _003C_003E1__state)
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
		private sealed class _003CPlayCharacter_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Entity main;

			private Animation _003Canimation_003E5__2;

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
			public _003CPlayCharacter_003Ed__23(int _003C_003E1__state)
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
		private sealed class _003CPlayVictory_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShowDungeonWinEffectCmd _003C_003E4__this;

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
			public _003CPlayVictory_003Ed__22(int _003C_003E1__state)
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
		private sealed class _003CSlowMotion_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShowDungeonWinEffectCmd _003C_003E4__this;

			public DungeonWinEffectEditor dungeonWinEffectEditor;

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
			public _003CSlowMotion_003Ed__24(int _003C_003E1__state)
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
		private sealed class _003CZoomCamera_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShowDungeonWinEffectCmd _003C_003E4__this;

			public DungeonWinEffectEditor dungeonWinEffectEditor;

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
			public _003CZoomCamera_003Ed__25(int _003C_003E1__state)
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
		public DungeonWinParameter Parameter { get; set; }

		[Inject]
		public DungeonWinCinematicData CinematicData { get; set; }

		[Inject]
		public DisableInputAndAISignal DisableInputAndAiSignal { get; set; }

		[Inject]
		public ShowDropMemoryShardEffectSignal ShowDropMemoryShardEffectSignal { get; set; }

		[Inject]
		public IBattleModeLogic BattleModeLogic { get; set; }

		public override void Execute()
		{
		}

		[IteratorStateMachine(typeof(_003CEffect_003Ed__21))]
		private IEnumerator Effect(DungeonWinParameter parameter)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPlayVictory_003Ed__22))]
		private IEnumerator PlayVictory()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPlayCharacter_003Ed__23))]
		private IEnumerator PlayCharacter(Entity main)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSlowMotion_003Ed__24))]
		private IEnumerator SlowMotion(DungeonWinEffectEditor dungeonWinEffectEditor)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CZoomCamera_003Ed__25))]
		private IEnumerator ZoomCamera(DungeonWinEffectEditor dungeonWinEffectEditor)
		{
			return null;
		}

		protected virtual void ShowWinPopup(DungeonWinParameter parameter)
		{
		}

		private void DisableUI(bool disable)
		{
		}
	}
}
