using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Effects
{
	public class EffectsPlayer
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			public EffectConfig ec;

			public EffectsPlayer _003C_003E4__this;

			internal void _003CWaitThenPlayFx_003Eb__0(bool success, GameObject vfx)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CWaitThenPlayCameraFx_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float waitTime;

			public CameraShakeConfig ec;

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
			public _003CWaitThenPlayCameraFx_003Ed__11(int _003C_003E1__state)
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
		private sealed class _003CWaitThenPlayCameraFx_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float waitTime;

			public SlowMotionConfig ec;

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
			public _003CWaitThenPlayCameraFx_003Ed__12(int _003C_003E1__state)
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
		private sealed class _003CWaitThenPlayFx_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EffectConfig ec;

			public EffectsPlayer _003C_003E4__this;

			public float waitTime;

			private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

			public string vfxPrefabPath;

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
			public _003CWaitThenPlayFx_003Ed__9(int _003C_003E1__state)
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

		private EffectFollowAnimationConfig config;

		private RoutineRunner routineRunner;

		private Entity entity;

		private Character caster;

		private Character lastAttacker;

		private Action<Character, Character> onEntityDeathByAttacker;

		public EffectsPlayer(EffectFollowAnimationConfig config, RoutineRunner routineRunner, Entity entity)
		{
		}

		private void PostOnDeathByAttacker(Character attacker, Character defender)
		{
		}

		public void OnAnimationStart(string name)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitThenPlayFx_003Ed__9))]
		private IEnumerator WaitThenPlayFx(EffectConfig ec, float waitTime, string vfxPrefabPath)
		{
			return null;
		}

		private void PlaySFx(string sfxPath)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitThenPlayCameraFx_003Ed__11))]
		private IEnumerator WaitThenPlayCameraFx(CameraShakeConfig ec, float waitTime)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWaitThenPlayCameraFx_003Ed__12))]
		private IEnumerator WaitThenPlayCameraFx(SlowMotionConfig ec, float waitTime)
		{
			return null;
		}

		public void OnAnimationEnd(string name)
		{
		}

		private bool IsDeathFacingBackwardAttacker()
		{
			return false;
		}

		private AnimationConfig FindAnimationConfig(string name)
		{
			return null;
		}

		private CameraAnimationConfig FindCameraAnimationConfig(string name)
		{
			return null;
		}
	}
}
