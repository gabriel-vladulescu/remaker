using UnityEngine;

public class SoulView2 : MonoBehaviour
{
	[HideInInspector]
	public Transform target;

	[HideInInspector]
	public Vector3 targetOffset;

	public ParticleSystem ParticleSystem;

	private Transform _trans;

	private Vector3 distance;

	private float delayMove;

	private float time;

	public float curveDuration;

	public Vector2 bounceY;

	private Vector3 start;

	private bool finishDrop;

	private GameObject fx;

	private float ex;

	private float elapsed;

	private float delayCollection;

	public TweenPosition TweenPosition;

	public Vector3 selfOffset;

	public void StartEffect(GameObject fx, Vector3 targetOffset, float delay, float delayMove)
	{
	}

	private void Update()
	{
	}

	public static Vector3 GetMidlePoint(Vector3 start, Vector3 end, float ex)
	{
		return default(Vector3);
	}

	public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, float t)
	{
		return default(Vector3);
	}
}
