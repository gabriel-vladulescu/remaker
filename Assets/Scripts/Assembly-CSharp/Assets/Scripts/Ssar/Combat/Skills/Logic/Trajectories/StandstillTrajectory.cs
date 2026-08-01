using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Trajectories
{
	public class StandstillTrajectory : Projectile.Trajectory
	{
		private Vector3 position;

		private bool isPosInitialized;

		public StandstillTrajectory()
		{
		}

		public StandstillTrajectory(Vector3 position)
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
