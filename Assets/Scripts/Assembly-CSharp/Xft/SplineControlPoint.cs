using UnityEngine;

namespace Xft
{
	public class SplineControlPoint
	{
		public Vector3 Position;

		public Vector3 Normal;

		public int ControlPointIndex;

		public int SegmentIndex;

		public float Dist;

		protected Spline mSpline;

		public SplineControlPoint NextControlPoint => null;

		public SplineControlPoint PreviousControlPoint => null;

		public Vector3 NextPosition => default(Vector3);

		public Vector3 PreviousPosition => default(Vector3);

		public Vector3 NextNormal => default(Vector3);

		public Vector3 PreviousNormal => default(Vector3);

		public bool IsValid => false;

		private Vector3 GetNext2Position()
		{
			return default(Vector3);
		}

		private Vector3 GetNext2Normal()
		{
			return default(Vector3);
		}

		public Vector3 Interpolate(float localF)
		{
			return default(Vector3);
		}

		public Vector3 InterpolateNormal(float localF)
		{
			return default(Vector3);
		}

		public void Init(Spline owner)
		{
		}
	}
}
