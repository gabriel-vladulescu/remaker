using UnityEngine;

namespace PigeonCoopToolkit.Effects.Trails
{
	[AddComponentMenu("Pigeon Coop Toolkit/Effects/Trail")]
	public class Trail : TrailRenderer_Base
	{
		public float MinVertexDistance;

		public int MaxNumberOfPoints;

		private Vector3 _lastPosition;

		private float _distanceMoved;

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		protected override void OnStartEmit()
		{
		}

		protected override void Reset()
		{
		}

		protected override void OnTranslate(Vector3 t)
		{
		}

		protected override int GetMaxNumberOfPoints()
		{
			return 0;
		}
	}
}
