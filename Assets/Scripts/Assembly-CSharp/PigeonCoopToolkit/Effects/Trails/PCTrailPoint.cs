using UnityEngine;

namespace PigeonCoopToolkit.Effects.Trails
{
	public class PCTrailPoint
	{
		public Vector3 Forward;

		public Vector3 Position;

		public int PointNumber;

		private float _timeActive;

		private float _distance;

		public virtual void Update(float deltaTime)
		{
		}

		public float TimeActive()
		{
			return 0f;
		}

		public void SetTimeActive(float time)
		{
		}

		public void SetDistanceFromStart(float distance)
		{
		}

		public float GetDistanceFromStart()
		{
			return 0f;
		}
	}
}
