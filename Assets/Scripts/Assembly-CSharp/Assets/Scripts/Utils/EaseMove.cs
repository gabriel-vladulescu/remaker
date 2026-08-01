using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Artemis;
using Com.LuisPedroFonseca.ProCamera2D;
using SSAR.BattleSystem.Camera;
using UnityEngine;

namespace Assets.Scripts.Utils
{
	public class EaseMove : MonoBehaviour
	{
		private class MoveTowardCornerAction
		{
			private GameObject gameObject;

			private Vector3 startPosition;

			private Vector3 lookAtPosition;

			private Vector3 destination;

			private float duration;

			private float lookatSpeed;

			private Vector3 startUp;

			private float elapsed;

			private EasingFunctions.EasingFunc progressFunc;

			private EasingFunctions.EasingFunc xAxisEasingFunc;

			private EasingFunctions.EasingFunc yAxisEasingFunc;

			private bool finish;

			private Vector3 previousPos;

			public bool Finish => false;

			public MoveTowardCornerAction(GameObject gameObject, Vector3 startPosition, Vector3 destination, Vector3 lookAtPosition, float duration, float lookatSpeed, Vector3 startUp, EasingFunctions.Functions progressFuncName, EasingFunctions.Functions xAxisFuncName, EasingFunctions.Functions yAxisFuncName)
			{
			}

			public void Update(float dt)
			{
			}
		}

		private class MoveTowardTargetAction
		{
			private GameObject gameObject;

			private Vector3 startPosition;

			private Vector3 destination;

			private float duration;

			private Action onFinish;

			private float elapsed;

			private bool finish;

			public bool Finish => false;

			public MoveTowardTargetAction(GameObject gameObject, Vector3 startPosition, Vector3 destination, float duration, Action onFinish)
			{
			}

			public void Update(float dt)
			{
			}
		}

		private class ShakeAction
		{
			private GameObject gameObject;

			private float duration;

			private float current_shake_intensity;

			private float shake_decay;

			private float elapsed;

			private bool finish;

			public ShakeAction(GameObject gameObject, float duration, float currentShakeIntensity, float shakeDecay)
			{
			}

			public void Update(float dt)
			{
			}

			private void Shake()
			{
			}
		}

		private class ScaleAction
		{
			private GameObject gameObject;

			private Vector3 from;

			private Vector3 to;

			private float duration;

			private float elapsed;

			private bool finish;

			public ScaleAction(GameObject gameObject, Vector3 from, Vector3 to, float duration)
			{
			}

			public void Update(float dt)
			{
			}
		}

		private class StopAnimation
		{
			private Animation animation;

			private float duration;

			private float elapsed;

			private bool finish;

			public StopAnimation(Animation animation, float duration)
			{
			}

			public void Update(float dt)
			{
			}
		}

		private class SlowMotion
		{
			[CompilerGenerated]
			private sealed class _003CWaitThenResetTimeScale_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public float duration;

				public float original;

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
				public _003CWaitThenResetTimeScale_003Ed__7(int _003C_003E1__state)
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

			private float duration;

			private float timeScale;

			private MonoBehaviour monoBehaviour;

			private bool activated;

			public SlowMotion(float duration, float timeScale, MonoBehaviour monoBehaviour)
			{
			}

			public void Act()
			{
			}

			public bool IsActivated()
			{
				return false;
			}

			[IteratorStateMachine(typeof(_003CWaitThenResetTimeScale_003Ed__7))]
			private IEnumerator WaitThenResetTimeScale(float duration, float original)
			{
				return null;
			}
		}

		[Serializable]
		public class MyShakeCameraData : ShakeCameraData
		{
			public int startAtFrame;

			private bool isActivated;

			public bool IsActivated
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public MyShakeCameraData(int startAtFrame, Vector2 strength, float duration, int vibrato = 10, float smoothness = 0.01f, float randomness = 0f, bool useRandomInitialAngle = false)
				: base(default(Vector2), 0f, 0, 0f)
			{
			}

			public MyShakeCameraData(int startAtFrame, Vector2 strength, float duration, int vibrato, float smoothness, float randomness, bool useRandomInitialAngel, Vector3 rotation, ShakeCameraConfigId configId)
				: base(default(Vector2), 0f, 0, 0f)
			{
			}
		}

		[Serializable]
		public class SoundFx
		{
			public int startAtFrame;

			public AudioClip sfx;

			public float volume;

			private bool isPlayed;

			public bool IsPlayed
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public SoundFx(int startAtFrame, AudioClip sfx, float volume)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CScale_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameObject go;

			public Vector3 to;

			public float duration;

			private float _003Ce_003E5__2;

			private Vector3 _003Cfrom_003E5__3;

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
			public _003CScale_003Ed__78(int _003C_003E1__state)
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

		protected const string idle = "Idle";

		protected const string shackle = "Shackle";

		public GameObject camera;

		public GameObject target;

		public GameObject shard;

		public int slowMotionStartFrame;

		public int slowMotionDurationInFrames;

		public float slowMotionTimeScale;

		public int moveTowardCornerDurationInFrames;

		public Vector3 startPosition;

		public Vector3 destination;

		public Vector3 destinationCenterOffset;

		public float lookatSpeed;

		public EasingFunctions.Functions progressFuncName;

		public EasingFunctions.Functions xAxisFuncName;

		public EasingFunctions.Functions yAxisFuncName;

		public int moveTowardTargetStartFrame;

		public int moveTowardTargetDurationInFrames;

		public int shakeStartFrame;

		public int shakeDurationInFrames;

		public float shake_decay;

		public float shake_intensity;

		public int scaleStartFrame;

		public int scaleDurationInFrames;

		public Vector3 scaleTo;

		public int hitVfxPlayAtFrame;

		public int hitVfxLoopPlayAtFrame;

		public int camZoom1AtFrame;

		public string camZoom1AtJoint;

		public float camZoom1EaseInDuration;

		public float camZoom1HoldDuration;

		public float camZoom1Zoom;

		public float camZoom1EndDuration;

		public string camZoom2AtJoint;

		public float camZoom2EaseInDuration;

		public float camZoom2HoldDuration;

		public float camZoom2Zoom;

		public int stopAnimationAtFrame;

		public int stopAnimationTransitionDurationInFrames;

		public MyShakeCameraData[] shakeCameraDatas;

		public Vector3 bodyShardScaleFrom;

		public Vector3 bodyShardScaleTo;

		public int bodyShardScaleDurationInFrames;

		public int anchorDisappearAtFrame;

		public int endAtFrame;

		public SoundFx[] soundFxs;

		[HideInInspector]
		public GameObject appearVfx;

		[HideInInspector]
		public GameObject hitVfx;

		[HideInInspector]
		public GameObject hitVfxLoop;

		[HideInInspector]
		public GameObject anchorPrefab;

		[HideInInspector]
		public Entity cameraEntity;

		[HideInInspector]
		public Action onEnd;

		private float elapsed;

		private Vector3 startUp;

		private Vector3 originalScale;

		private MoveTowardCornerAction moveTowardCornerAction;

		private MoveTowardTargetAction moveTowardTargetAction;

		private ShakeAction shakeAction;

		private ScaleAction scaleAction;

		private GameObject anchorGo;

		private GameObject hitLoopGo;

		private GameObject targetChest;

		private ProCamera2D proCamera2D;

		private StopAnimation stopAnimation;

		private SlowMotion slowMotion;

		private bool appearVfxSpawn;

		private bool camZoom1;

		private bool camZoom2;

		private bool disappearVfxSpawn;

		private bool hitVfxSpawn;

		private bool hitVfxLoopSpawn;

		private bool onEndInvoked;

		protected virtual string ChestJointName()
		{
			return null;
		}

		protected virtual string CamZoom1AtJoint()
		{
			return null;
		}

		protected virtual string CamZoom2AtJoint()
		{
			return null;
		}

		private void Start()
		{
		}

		private void Replay()
		{
		}

		private void OnReachTarget()
		{
		}

		[IteratorStateMachine(typeof(_003CScale_003Ed__78))]
		private IEnumerator Scale(GameObject go, Vector3 to, float duration)
		{
			return null;
		}

		private void Update()
		{
		}

		private void CamZoom()
		{
		}

		private void MoveTowardCorner(float dt)
		{
		}
	}
}
