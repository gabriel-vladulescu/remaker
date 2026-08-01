using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Trajectories
{
	[Serializable]
	public class CircularTrajectoryConfig
	{
		public float startAngle;

		public float radius;

		public float circularSpeed;

		public Vector2 offset;

		public float delay;

		public CircularTrajectoryConfig()
		{
		}

		public CircularTrajectoryConfig(float startAngle, float radius, float circularSpeed, Vector2 offset)
		{
		}

		public CircularTrajectoryConfig(float startAngle, float radius, float circularSpeed, Vector2 offset, float delay)
		{
		}
	}
}
