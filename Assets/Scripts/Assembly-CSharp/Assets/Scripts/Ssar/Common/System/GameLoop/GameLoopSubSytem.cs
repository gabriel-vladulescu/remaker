using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Core.Scheduling;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using UnityEngine;

namespace Assets.Scripts.Ssar.Common.System.GameLoop
{
	public class GameLoopSubSytem : SubSystem, GameLoop
	{
		[CompilerGenerated]
		private sealed class _003CRun_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameLoopSubSytem _003C_003E4__this;

			private WaitForFixedUpdate _003Cwaiter_003E5__2;

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
			public _003CRun_003Ed__16(int _003C_003E1__state)
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

		public static uint SIM_TIME_PER_FRAME;

		public static float VIEW_PHYSICS_TIME_PER_FRAME;

		private Assets.Scripts.Ssar.Common.System.RoutineRunner.RoutineRunner routineRunner;

		private SimTimeEngine simTimeEngine;

		private ViewTimeEngine viewTimeEngine;

		public GameLoopSubSytem(Assets.Scripts.Ssar.Common.System.RoutineRunner.RoutineRunner routineRunner)
		{
		}

		public void RegisterSimTimeObserver(SimTimeObserver observer)
		{
		}

		public void UnregisterSimTimeObserver(SimTimeObserver observer)
		{
		}

		public void RegisterPhysicsTimeObserver(ViewPhysicsTimeObserver observer)
		{
		}

		public void UnregisterPhysicsTimeObserver(ViewPhysicsTimeObserver observer)
		{
		}

		public void RegisterFrameTimeObserver(ViewFrameTimeObserver observer)
		{
		}

		public void UnregisterFrameTimeObserver(ViewFrameTimeObserver observer)
		{
		}

		public void RegisterClockTimeObserver(ClockTimeObserver observer, float tickSize)
		{
		}

		public void UnregisterClockTimeObserver(ClockTimeObserver observer)
		{
		}

		public void StartUp()
		{
		}

		public void ShutDown()
		{
		}

		[IteratorStateMachine(typeof(_003CRun_003Ed__16))]
		public IEnumerator Run()
		{
			return null;
		}

		public void Scale(float scale)
		{
		}
	}
}
