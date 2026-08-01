using UnityEngine;

public class SplineWalker
{
	private BezierSpline spline;

	private float duration;

	private bool lookForward;

	private SplineWalkerMode mode;

	private Transform transform;

	private float progress;

	private bool goingForward;

	public SplineWalker(BezierSpline spline, float duration, bool lookForward, SplineWalkerMode mode, Transform transform)
	{
	}

	public void Update(float dt)
	{
	}

	public float ShowProgress()
	{
		return 0f;
	}
}
