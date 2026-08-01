using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
	public class Door : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CMoveRoutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public Door _003C_003E4__this;

			public float duration;

			public Vector3 newPos;

			private Vector3 _003CorigPos_003E5__2;

			private float _003Ct_003E5__3;

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
			public _003CMoveRoutine_003Ed__14(int _003C_003E1__state)
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

		private bool _isOpen;

		public DoorDirection DoorDirection;

		public float MovementRange;

		public float AnimDuration;

		public float OpenDelay;

		public float CloseDelay;

		private Vector3 _origPos;

		private Coroutine _moveCoroutine;

		public bool IsOpen => false;

		private void Awake()
		{
		}

		public void OpenDoor(float openDelay = -1f)
		{
		}

		public void CloseDoor()
		{
		}

		private void Move(Vector3 newPos, float duration, float delay)
		{
		}

		[IteratorStateMachine(typeof(_003CMoveRoutine_003Ed__14))]
		private IEnumerator MoveRoutine(Vector3 newPos, float duration, float delay)
		{
			return null;
		}
	}
}
