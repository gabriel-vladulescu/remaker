using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Dungeon.Command;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic.Arena;
using Assets.Scripts.Ssar.Dungeon.View;
using SSAR.BattleSystem.Camera;
using Scripts.Config;
using strange.extensions.injector.api;

namespace Assets.Scripts.Ssar.Dungeon.GameModeLogic
{
	public class ArenaDungeonStartLogic : IDungeonStartLogic
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			public bool finishCameraFx;

			public bool finishStartFx;

			public ArenaInterfaceView dungeonInterfaceView;

			internal void _003CEffectPrepare_003Eb__0()
			{
			}

			internal void _003CEffectPrepare_003Eb__1()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public bool finish;

			internal void _003CSelectRune_003Eb__0(ArenaRuneInfo runeInfo)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCameraFx_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ArenaDungeonStartLogic _003C_003E4__this;

			public Action finish;

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
			public _003CCameraFx_003Ed__6(int _003C_003E1__state)
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
		private sealed class _003CEffectPrepare_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public IInjectionBinder injectionBinder;

			private _003C_003Ec__DisplayClass2_0 _003C_003E8__1;

			public ArenaDungeonStartLogic _003C_003E4__this;

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
			public _003CEffectPrepare_003Ed__2(int _003C_003E1__state)
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
		private sealed class _003CSelectRune_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ArenaDungeonStartLogic _003C_003E4__this;

			public ArenaInterfaceView arenaInterfaceView;

			private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

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
			public _003CSelectRune_003Ed__3(int _003C_003E1__state)
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
		private sealed class _003CShowBlackMask_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public float duration;

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
			public _003CShowBlackMask_003Ed__8(int _003C_003E1__state)
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

		private ArenaModeParameter parameter;

		public ArenaDungeonStartLogic(ArenaModeParameter parameter)
		{
		}

		[IteratorStateMachine(typeof(_003CEffectPrepare_003Ed__2))]
		public IEnumerator EffectPrepare(IInjectionBinder injectionBinder)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSelectRune_003Ed__3))]
		private IEnumerator SelectRune(ArenaInterfaceView arenaInterfaceView)
		{
			return null;
		}

		public void OnDungeonStart()
		{
		}

		public bool EnablePrepare()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CCameraFx_003Ed__6))]
		private IEnumerator CameraFx(Action finish)
		{
			return null;
		}

		private CinematicCameraControl Create(Action finish)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CShowBlackMask_003Ed__8))]
		private IEnumerator ShowBlackMask(float delay, float duration)
		{
			return null;
		}

		private ShowArenaOpponentInfoPopupParameter Generate()
		{
			return null;
		}
	}
}
