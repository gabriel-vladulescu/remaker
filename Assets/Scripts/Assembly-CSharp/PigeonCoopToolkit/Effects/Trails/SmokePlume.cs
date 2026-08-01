using UnityEngine;

namespace PigeonCoopToolkit.Effects.Trails
{
	[AddComponentMenu("Pigeon Coop Toolkit/Effects/Smoke Plume")]
	public class SmokePlume : TrailRenderer_Base
	{
		public float TimeBetweenPoints;

		public Vector3 ConstantForce;

		public float RandomForceScale;

		public int MaxNumberOfPoints;

		private float _timeSincePoint;

		protected override void Start()
		{
		}

		protected override void OnStartEmit()
		{
		}

		protected override void Reset()
		{
		}

		protected override void Update()
		{
		}

		protected override void InitialiseNewPoint(PCTrailPoint newPoint)
		{
		}

		protected override void UpdateTrail(PCTrail trail, float deltaTime)
		{
		}

		protected override int GetMaxNumberOfPoints()
		{
			return 0;
		}
	}
}
