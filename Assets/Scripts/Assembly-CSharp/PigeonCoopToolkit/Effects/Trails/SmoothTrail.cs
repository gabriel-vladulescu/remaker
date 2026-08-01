using PigeonCoopToolkit.Utillities;
using UnityEngine;

namespace PigeonCoopToolkit.Effects.Trails
{
	[AddComponentMenu("Pigeon Coop Toolkit/Effects/Smooth Trail")]
	public class SmoothTrail : TrailRenderer_Base
	{
		private class ControlPoint
		{
			public Vector3 p;

			public Vector3 forward;
		}

		public float MinControlPointDistance;

		public int MaxControlPoints;

		public int PointsBetweenControlPoints;

		private Vector3 _lastPosition;

		private float _distanceMoved;

		private CircularBuffer<ControlPoint> _controlPoints;

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		protected override void OnStartEmit()
		{
		}

		protected override void UpdateTrail(PCTrail trail, float deltaTime)
		{
		}

		protected override void Reset()
		{
		}

		protected override void OnTranslate(Vector3 t)
		{
		}

		private void AddControlPoint(Vector3 position)
		{
		}

		protected override int GetMaxNumberOfPoints()
		{
			return 0;
		}

		public Vector3 GetPointAlongCurve(Vector3 curveStart, Vector3 curveStartHandle, Vector3 curveEnd, Vector3 curveEndHandle, float t, float crease)
		{
			return default(Vector3);
		}
	}
}
