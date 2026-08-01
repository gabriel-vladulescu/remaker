using System;
using Assets.Scripts.Core.Skills.Projectiles;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Trajectories
{
	[Serializable]
	public class JumpTrajectoryConfig : ITrajectoryConfig
	{
		public float jumpHeight;

		public float jumpDurationReachMaxHeight;

		public float jumpDurationLandGround;

		public float floatingDuration;

		public float jumpDistance;

		public float targetOffsetX;
	}
}
