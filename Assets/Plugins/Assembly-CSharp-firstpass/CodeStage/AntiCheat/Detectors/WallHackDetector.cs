using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/WallHack Detector")]
	public class WallHackDetector : ActDetectorBase
	{
		[CompilerGenerated]
		private sealed class _003CCaptureFrame_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WallHackDetector _003C_003E4__this;

			private RenderTexture _003CpreviousActive_003E5__2;

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
			public _003CCaptureFrame_003Ed__83(int _003C_003E1__state)
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
		private sealed class _003CInitDetector_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WallHackDetector _003C_003E4__this;

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
			public _003CInitDetector_003Ed__78(int _003C_003E1__state)
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

		internal const string COMPONENT_NAME = "WallHack Detector";

		internal const string FINAL_LOG_PREFIX = "[ACTk] WallHack Detector: ";

		private const string SERVICE_CONTAINER_NAME = "[WH Detector Service]";

		private const string WIREFRAME_SHADER_NAME = "Hidden/ACTk/WallHackTexture";

		private const int SHADER_TEXTURE_SIZE = 4;

		private const int RENDER_TEXTURE_SIZE = 4;

		private readonly Vector3 rigidPlayerVelocity;

		private static int instancesInScene;

		private readonly WaitForEndOfFrame waitForEndOfFrame;

		[SerializeField]
		[Tooltip("Check for the \"walk through the walls\" kind of cheats made via Rigidbody hacks?")]
		private bool checkRigidbody;

		[SerializeField]
		[Tooltip("Check for the \"walk through the walls\" kind of cheats made via Character Controller hacks?")]
		private bool checkController;

		[SerializeField]
		[Tooltip("Check for the \"see through the walls\" kind of cheats made via shader or driver hacks (wireframe, color alpha, etc.)?")]
		private bool checkWireframe;

		[SerializeField]
		[Tooltip("Check for the \"shoot through the walls\" kind of cheats made via Raycast hacks?")]
		private bool checkRaycast;

		[Tooltip("Delay between Wireframe module checks, from 1 up to 60 secs.")]
		[Range(1f, 60f)]
		public int wireframeDelay;

		[Tooltip("Delay between Raycast module checks, from 1 up to 60 secs.")]
		[Range(1f, 60f)]
		public int raycastDelay;

		[Tooltip("World position of the container for service objects within 3x3x3 cube (drawn as red wire cube in scene).")]
		public Vector3 spawnPosition;

		[Tooltip("Maximum false positives in a row for each detection module before registering a wall hack.")]
		public byte maxFalsePositives;

		private GameObject serviceContainer;

		private GameObject solidWall;

		private GameObject thinWall;

		private Camera wfCamera;

		private MeshRenderer foregroundRenderer;

		private MeshRenderer backgroundRenderer;

		private Color wfColor1;

		private Color wfColor2;

		private Shader wfShader;

		private Material wfMaterial;

		private Texture2D shaderTexture;

		private Texture2D targetTexture;

		private RenderTexture renderTexture;

		private int whLayer;

		private int raycastMask;

		private Rigidbody rigidPlayer;

		private CharacterController charControllerPlayer;

		private float charControllerVelocity;

		private byte rigidbodyDetections;

		private byte controllerDetections;

		private byte wireframeDetections;

		private byte raycastDetections;

		private bool wireframeDetected;

		public bool CheckRigidbody
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CheckController
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CheckWireframe
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CheckRaycast
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static WallHackDetector Instance { get; private set; }

		private static WallHackDetector GetOrCreateInstance => null;

		public static void StartDetection()
		{
		}

		public static void StartDetection(UnityAction callback)
		{
		}

		public static void StartDetection(UnityAction callback, Vector3 spawnPosition)
		{
		}

		public static void StartDetection(UnityAction callback, Vector3 spawnPosition, byte maxFalsePositives)
		{
		}

		public static void StopDetection()
		{
		}

		public static void Dispose()
		{
		}

		private WallHackDetector()
		{
		}

		private void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		private void OnLevelLoadedCallback()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		private void StartDetectionInternal(UnityAction callback, Vector3 servicePosition, byte falsePositivesInRow)
		{
		}

		protected override void StartDetectionAutomatically()
		{
		}

		protected override void PauseDetector()
		{
		}

		protected override void ResumeDetector()
		{
		}

		protected override void StopDetectionInternal()
		{
		}

		protected override void DisposeInternal()
		{
		}

		private void UpdateServiceContainer()
		{
		}

		[IteratorStateMachine(typeof(_003CInitDetector_003Ed__78))]
		private IEnumerator InitDetector()
		{
			return null;
		}

		private void StartRigidModule()
		{
		}

		private void StartControllerModule()
		{
		}

		private void StartWireframeModule()
		{
		}

		private void ShootWireframeModule()
		{
		}

		[IteratorStateMachine(typeof(_003CCaptureFrame_003Ed__83))]
		private IEnumerator CaptureFrame()
		{
			return null;
		}

		private void StartRaycastModule()
		{
		}

		private void ShootRaycastModule()
		{
		}

		private void StopRigidModule()
		{
		}

		private void StopControllerModule()
		{
		}

		private void StopWireframeModule()
		{
		}

		private void StopRaycastModule()
		{
		}

		private void InitRigidModule()
		{
		}

		private void InitControllerModule()
		{
		}

		private void UninitRigidModule()
		{
		}

		private void UninitControllerModule()
		{
		}

		private bool Detect()
		{
			return false;
		}

		private static Color32 GenerateColor()
		{
			return default(Color32);
		}

		private static bool ColorsSimilar(Color32 c1, Color32 c2, int tolerance)
		{
			return false;
		}
	}
}
