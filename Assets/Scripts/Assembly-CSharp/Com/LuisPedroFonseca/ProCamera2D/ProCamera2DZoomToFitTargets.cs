using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
	[HelpURL("http://www.procamera2d.com/user-guide/extension-zoom-to-fit/")]
	public class ProCamera2DZoomToFitTargets : BasePC2D, ISizeOverrider
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ProCamera2DZoomToFitTargets _003C_003E4__this;

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
			public _003CStart_003Ed__17(int _003C_003E1__state)
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

		public float ZoomOutBorder;

		public float ZoomInBorder;

		public float ZoomInSmoothness;

		public float ZoomOutSmoothness;

		public float MaxZoomInAmount;

		public float MaxZoomOutAmount;

		public bool DisableWhenOneTarget;

		private float _zoomVelocity;

		private float _initialCamSize;

		private float _previousCamSize;

		private float _targetCamSize;

		private float _targetCamSizeSmoothed;

		private float _minCameraSize;

		private float _maxCameraSize;

		private int _soOrder;

		public int SOOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__17))]
		private IEnumerator Start()
		{
			return null;
		}

		public float OverrideSize(float deltaTime, float originalSize)
		{
			return 0f;
		}

		public override void OnReset()
		{
		}

		private void UpdateTargetCamSize()
		{
		}
	}
}
