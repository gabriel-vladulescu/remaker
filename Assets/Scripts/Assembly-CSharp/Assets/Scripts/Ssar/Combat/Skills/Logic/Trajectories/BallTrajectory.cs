using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Trajectories
{
	public class BallTrajectory : CannonTrajectory
	{
		private BallTrajectoryConfig config;

		private float groundY;

		private int bouncingCount;

		private Vector2 configVelocity;

		private float elapsed;

		private ProjectileFactory.DefaultCollider collider;

		public BallTrajectory(BallTrajectoryConfig config, Direction characterDirection, float groundY)
			: base(null, default(Direction))
		{
		}

		public override void Update(float dt, Projectile projectile, Vector3 currentPosition)
		{
		}
	}
}
