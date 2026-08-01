using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Trajectories
{
	public class BallTrajectoryConfig : CannonTrajectoryConfig
	{
		public Vector2 velocityDecayConstant;

		public float delayGroundCollision;
	}
}
