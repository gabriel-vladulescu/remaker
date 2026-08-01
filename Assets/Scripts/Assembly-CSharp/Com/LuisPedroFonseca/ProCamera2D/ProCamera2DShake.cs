using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
	[HelpURL("http://www.procamera2d.com/user-guide/extension-shake/")]
	public class ProCamera2DShake : BasePC2D
	{
		[CompilerGenerated]
		private sealed class _003CApplyShakeTimedRoutine_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ProCamera2DShake _003C_003E4__this;

			public bool ignoreTimeScale;

			public float duration;

			public Vector2 shake;

			public Quaternion rotation;

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
			public _003CApplyShakeTimedRoutine_003Ed__38(int _003C_003E1__state)
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
		private sealed class _003CApplyShakesTimedRoutine_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float[] durations;

			public ProCamera2DShake _003C_003E4__this;

			public IList<Vector2> shakes;

			public IList<Quaternion> rotations;

			public bool ignoreTimeScale;

			private int _003Ccount_003E5__2;

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
			public _003CApplyShakesTimedRoutine_003Ed__37(int _003C_003E1__state)
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
		private sealed class _003CShakeRoutine_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ProCamera2DShake _003C_003E4__this;

			public bool ignoreTimeScale;

			public float smoothness;

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
			public _003CShakeRoutine_003Ed__36(int _003C_003E1__state)
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

		public static string ExtensionName;

		private static ProCamera2DShake _instance;

		public Action OnShakeCompleted;

		public Vector2 Strength;

		[Range(0.02f, 3f)]
		public float Duration;

		[Range(1f, 100f)]
		public int Vibrato;

		[Range(0f, 1f)]
		public float Randomness;

		[Range(0f, 0.5f)]
		public float Smoothness;

		[Range(0f, 360f)]
		public float InitialAngle;

		public bool UseRandomInitialAngle;

		public Vector3 Rotation;

		public bool IgnoreTimeScale;

		public List<ShakePreset> ShakePresets;

		private Transform _shakeParent;

		private List<Coroutine> _applyInfluencesCoroutines;

		private Coroutine _shakeCoroutine;

		private Vector3 _shakeVelocity;

		private List<Vector3> _shakePositions;

		private Quaternion _rotationTarget;

		private Quaternion _originalRotation;

		private float _rotationTime;

		private float _rotationVelocity;

		private List<Vector3> _influences;

		private Vector3 _influencesSum;

		public static ProCamera2DShake Instance => null;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		public void Shake()
		{
		}

		public void Shake(float duration, Vector2 strength, int vibrato = 10, float randomness = 0.1f, float initialAngle = -1f, Vector3 rotation = default(Vector3), float smoothness = 0.1f, bool ignoreTimeScale = false)
		{
		}

		public void ShakeUsingPreset(int presetIndex)
		{
		}

		public void ShakeUsingPreset(string presetName)
		{
		}

		public void StopShaking()
		{
		}

		public Coroutine ApplyShakesTimed(Vector2[] shakes, Vector3[] rotations, float[] durations, float smoothness = 0.1f, bool ignoreTimeScale = false)
		{
			return null;
		}

		public void ApplyInfluenceIgnoringBoundaries(Vector2 influence)
		{
		}

		private Coroutine ApplyShakesTimed(Vector2[] shakes, Quaternion[] rotations, float[] durations, float smoothness = 0.1f, bool ignoreTimeScale = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CShakeRoutine_003Ed__36))]
		private IEnumerator ShakeRoutine(float smoothness, bool ignoreTimeScale = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CApplyShakesTimedRoutine_003Ed__37))]
		private IEnumerator ApplyShakesTimedRoutine(IList<Vector2> shakes, IList<Quaternion> rotations, float[] durations, bool ignoreTimeScale = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CApplyShakeTimedRoutine_003Ed__38))]
		private IEnumerator ApplyShakeTimedRoutine(Vector2 shake, Quaternion rotation, float duration, bool ignoreTimeScale = false)
		{
			return null;
		}
	}
}
