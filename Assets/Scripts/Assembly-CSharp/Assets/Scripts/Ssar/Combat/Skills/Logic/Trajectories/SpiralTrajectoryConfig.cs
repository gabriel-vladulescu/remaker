using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Trajectories
{
	[Serializable]
	public class SpiralTrajectoryConfig
	{
		public float initialAngle;

		public float initialRadius;

		public float circularSpeed;

		public float radiusSpeed;

		public float delay;

		public Vector2 offset;

		public SpiralTrajectoryConfig()
		{
		}

		public SpiralTrajectoryConfig(float initialAngle, float initialRadius, float circularSpeed, float radiusSpeed, float delay, Vector2 offset)
		{
		}

		public SpiralTrajectoryConfig(float initialAngle, float initialRadius, float circularSpeed, float radiusSpeed, float delay)
		{
		}
	}
}
