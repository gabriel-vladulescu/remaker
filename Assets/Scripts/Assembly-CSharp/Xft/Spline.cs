using System.Collections.Generic;
using UnityEngine;

namespace Xft
{
	public class Spline
	{
		private List<SplineControlPoint> mControlPoints;

		private List<SplineControlPoint> mSegments;

		public int Granularity;

		public SplineControlPoint this[int index] => null;

		public List<SplineControlPoint> Segments => null;

		public List<SplineControlPoint> ControlPoints => null;

		public SplineControlPoint NextControlPoint(SplineControlPoint controlpoint)
		{
			return null;
		}

		public SplineControlPoint PreviousControlPoint(SplineControlPoint controlpoint)
		{
			return null;
		}

		public Vector3 NextPosition(SplineControlPoint controlpoint)
		{
			return default(Vector3);
		}

		public Vector3 PreviousPosition(SplineControlPoint controlpoint)
		{
			return default(Vector3);
		}

		public Vector3 PreviousNormal(SplineControlPoint controlpoint)
		{
			return default(Vector3);
		}

		public Vector3 NextNormal(SplineControlPoint controlpoint)
		{
			return default(Vector3);
		}

		public SplineControlPoint LenToSegment(float t, out float localF)
		{
			localF = default(float);
			return null;
		}

		public static Vector3 CatmulRom(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		public Vector3 InterpolateByLen(float tl)
		{
			return default(Vector3);
		}

		public Vector3 InterpolateNormalByLen(float tl)
		{
			return default(Vector3);
		}

		public SplineControlPoint AddControlPoint(Vector3 pos, Vector3 up)
		{
			return null;
		}

		public void Clear()
		{
		}

		private void RefreshDistance()
		{
		}

		public void RefreshSpline()
		{
		}
	}
}
