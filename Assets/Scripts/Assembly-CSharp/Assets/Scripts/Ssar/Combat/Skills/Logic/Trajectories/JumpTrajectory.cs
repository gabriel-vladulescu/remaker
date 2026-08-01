using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Trajectories
{
	public class JumpTrajectory : Projectile.Trajectory
	{
		private readonly JumpGravityControl gravityControl;

		private Vector3 velocity;

		public JumpTrajectory(JumpTrajectoryConfig trajectory, float direction)
		{
		}

		public Direction AdjustCharacterFacingDirectionParam(Direction currentDirection, Direction directionAtTheTimeOfFirstProjectileCreation)
		{
			return default(Direction);
		}

		public Vector3 AdjustCharacterPositionParam(Vector3 currentCharacterPosition, Vector3 characterPositionAtTheTimeOfFirstProjectileCreation)
		{
			return default(Vector3);
		}

		public void Update(float dt, Projectile projectile, Vector3 currentPosition)
		{
		}
	}
}
