using UnityEngine;

[ExecuteInEditMode]
public class WFX_Turbulence : MonoBehaviour
{
	public enum MoveMethodEnum
	{
		Position = 0,
		Velocity = 1,
		RelativePositionHalf = 2,
		RelativePosition = 3
	}

	public enum PerfomanceEnum
	{
		UltraRealTime = 0,
		High = 1,
		Low = 2
	}

	public float TurbulenceStrenght;

	public bool TurbulenceByTime;

	public AnimationCurve TurbulenceStrengthByTime;

	public Vector3 Frequency;

	public Vector3 OffsetSpeed;

	public Vector3 Amplitude;

	public Vector3 GlobalForce;

	public MoveMethodEnum MoveMethod;

	public PerfomanceEnum Perfomance;

	private float lastStopTime;

	private Vector3 currentOffset;

	private float deltaTime;

	private float deltaTimeLastUpdateOffset;

	private ParticleSystem.Particle[] particleArray;

	private ParticleSystem particleSys;

	private float time;

	private int currentSplit;

	private float fpsTime;

	private int FPS;

	private int splitUpdate;

	private PerfomanceEnum perfomanceOldSettings;

	private bool skipFrame;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdatePerfomanceSettings()
	{
	}

	private void UpdateTurbulence()
	{
	}
}
