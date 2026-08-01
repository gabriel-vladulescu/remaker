using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Speed Hack Detector")]
	public class SpeedHackDetector : ActDetectorBase
	{
		internal const string COMPONENT_NAME = "Speed Hack Detector";

		internal const string FINAL_LOG_PREFIX = "[ACTk] Speed Hack Detector: ";

		private const long TICKS_PER_SECOND = 10000000L;

		private const int THRESHOLD = 5000000;

		private static int instancesInScene;

		[Tooltip("Time (in seconds) between detector checks.")]
		public float interval;

		[Tooltip("Maximum false positives count allowed before registering speed hack.")]
		public byte maxFalsePositives;

		[Tooltip("Amount of sequential successful checks before clearing internal false positives counter.\nSet 0 to disable Cool Down feature.")]
		public int coolDown;

		private byte currentFalsePositives;

		private int currentCooldownShots;

		private long ticksOnStart;

		private long vulnerableTicksOnStart;

		private long prevTicks;

		private long prevIntervalTicks;

		public static SpeedHackDetector Instance { get; private set; }

		private static SpeedHackDetector GetOrCreateInstance => null;

		public static void StartDetection()
		{
		}

		public static void StartDetection(UnityAction callback)
		{
		}

		public static void StartDetection(UnityAction callback, float interval)
		{
		}

		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives)
		{
		}

		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives, int coolDown)
		{
		}

		public static void StopDetection()
		{
		}

		public static void Dispose()
		{
		}

		private SpeedHackDetector()
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

		private void OnApplicationPause(bool pause)
		{
		}

		private void Update()
		{
		}

		private void StartDetectionInternal(UnityAction callback, float checkInterval, byte falsePositives, int shotsTillCooldown)
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

		private void ResetStartTicks()
		{
		}
	}
}
