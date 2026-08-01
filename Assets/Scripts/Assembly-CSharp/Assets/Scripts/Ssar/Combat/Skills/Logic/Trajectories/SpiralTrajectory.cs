using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Trajectories
{
	public class SpiralTrajectory : Projectile.Trajectory
	{
		private SpiralTrajectoryConfig config;

		private Vector2 centerPos;

		private float angle;

		private float radius;

		private float delay;

		public SpiralTrajectory(SpiralTrajectoryConfig config)
		{
		}

		public void UpdateCenterPos(Vector2 pos)
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
