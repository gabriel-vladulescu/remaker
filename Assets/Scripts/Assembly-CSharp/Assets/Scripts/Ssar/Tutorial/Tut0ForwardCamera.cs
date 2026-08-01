using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SSAR.BattleSystem.Camera;
using UnityEngine;

namespace Assets.Scripts.Ssar.Tutorial
{
	public class Tut0ForwardCamera
	{
		[CompilerGenerated]
		private sealed class _003CRun_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Tut0ForwardCamera _003C_003E4__this;

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
			public _003CRun_003Ed__13(int _003C_003E1__state)
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

		private AnimationCurve animationCurve;

		private bool done;

		private float deltaTime;

		private float duration;

		private float time;

		private float originalPosRight;

		private float extendRight;

		private float originalPosLeft;

		private float extendLeft;

		private CameraComponent cameraComponent;

		private Action onFinish;

		public Tut0ForwardCamera(CameraComponent cameraComponent, Vector3 targetPosRight, Action onFinish)
		{
		}

		public Tut0ForwardCamera(CameraComponent cameraComponent, Vector3 targetPosLeft, Vector3 targetPosRight, Action onFinish)
		{
		}

		[IteratorStateMachine(typeof(_003CRun_003Ed__13))]
		private IEnumerator Run()
		{
			return null;
		}
	}
}
