using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Trajectories
{
	public class CannonTrajectory : Projectile.Trajectory
	{
		private Vector2 initialVelocity;

		private Vector2 gravity;

		private Vector2 velocity;

		public Vector2 InitialVelocity
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public CannonTrajectory(CannonTrajectoryConfig config, Direction characterDirection)
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

		public virtual void Update(float dt, Projectile projectile, Vector3 currentPosition)
		{
		}
	}
}
