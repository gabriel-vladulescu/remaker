using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
	public class EnemyWander : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCheckAgentPosition_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EnemyWander _003C_003E4__this;

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
			public _003CCheckAgentPosition_003Ed__10(int _003C_003E1__state)
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

		public float WanderDuration;

		public float WaypointOffset;

		public float WanderRadius;

		private NavMeshAgent _navMeshAgent;

		private bool _hasReachedDestination;

		private Vector3 _startingPos;

		private float _startingTime;

		private void Awake()
		{
		}

		public void StartWandering()
		{
		}

		public void StopWandering()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckAgentPosition_003Ed__10))]
		private IEnumerator CheckAgentPosition()
		{
			return null;
		}

		private void GoToWaypoint()
		{
		}
	}
}
