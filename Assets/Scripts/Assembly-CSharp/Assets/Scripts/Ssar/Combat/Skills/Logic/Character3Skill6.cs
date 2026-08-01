using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class Character3Skill6 : DefaultRangerSkill
	{
		public class Character3Skill6Info
		{
			public float sphereRadius;

			public float flyDuration;
		}

		private class StandStillIfHitWallTrajectory : Projectile.Trajectory
		{
			private float flyDuration;

			private float mostLeft;

			private float mostRight;

			private float projectileRadius;

			private float elapsed;

			private Vector3 previousPos;

			public StandStillIfHitWallTrajectory(float flyDuration, float mostLeft, float mostRight, float projectileRadius)
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

		private Character3Skill6Info info;

		private Environment environment;

		public Character3Skill6(Dependencies dependencies)
			: base(null)
		{
		}

		protected override bool ShouldDestroyProjectileOnTargetHit()
		{
			return false;
		}

		protected override bool ShouldDestroyProjectileOnObstacleHit()
		{
			return false;
		}

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}
	}
}
