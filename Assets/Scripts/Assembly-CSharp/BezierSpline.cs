using UnityEngine;

public class BezierSpline
{
	private Vector3[] points;

	private BezierControlPointMode[] modes;

	private bool loop;

	private Transform transform;

	public int CurveCount => 0;

	public BezierSpline(Vector3[] points, BezierControlPointMode[] modes, bool loop, Transform transform)
	{
	}

	public Vector3 GetPoint(float t)
	{
		return default(Vector3);
	}

	public Vector3 GetVelocity(float t)
	{
		return default(Vector3);
	}

	public Vector3 GetDirection(float t)
	{
		return default(Vector3);
	}
}
