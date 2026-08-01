using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class SlowmotionCamera
	{
		[CompilerGenerated]
		private sealed class _003CLoop_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SlowmotionCamera _003C_003E4__this;

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
			public _003CLoop_003Ed__7(int _003C_003E1__state)
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
		private sealed class _003CWaitThenResetTimeScale_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float waitTime;

			public float timeScale;

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
			public _003CWaitThenResetTimeScale_003Ed__8(int _003C_003E1__state)
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

		private const float easingDuration = 0.1f;

		private RoutineRunner routineRunner;

		private CameraSlowMotion cameraSlowMotion;

		private float original;

		private float elapsed;

		public SlowmotionCamera(RoutineRunner routineRunner, CameraSlowMotion cameraSlowMotion)
		{
		}

		public void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CLoop_003Ed__7))]
		private IEnumerator Loop()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWaitThenResetTimeScale_003Ed__8))]
		private IEnumerator WaitThenResetTimeScale(float waitTime, float timeScale, float fixedDt)
		{
			return null;
		}
	}
}
